'use strict';

let btnLogin = document.getElementById('btnLogin');
let btnAcceptFriend = document.getElementById('btnAcceptFriend');
let btnReload = document.getElementById('btnReload');
let radioAccount = document.getElementById('radioAccount');
let btnShowPwd = document.getElementById('btnShowPwd');

let accounts = {};
let keys = [];
let indentify, password, submit, logout, checked = null;

chrome.storage.sync.get(['accounts', 'checked', 'keys'], function (data) {
  ({ accounts, checked, keys } = data);

  const renderRadio = (acc, i, key) => {
    var input = document.createElement('input');
    input.setAttribute('type', 'radio');
    input.setAttribute('name', 'account');
    input.classList.add('selectRadio');
    input.value = i;
    if (checked === acc.username) input.checked = true;
    else if (i === 0) input.checked = true;

    var label = document.createElement('label');
    label.innerHTML = '<span class="selectRadio" style="font-weight: bold;">' + key + '</span> <span class="selectRadio h-badge hide"></span> <br/> <small class="selectRadio" style="font-style: italic;">' + acc.username + '</small> <br/> <small class="selectRadio pwd hide" style="font-style: italic">' + acc.password + '</small>';

    var div = document.createElement('div');
    div.setAttribute('style', 'display: flex;');

    div.appendChild(input);
    div.appendChild(label);
    div.classList.add('selectRadio');

    div.addEventListener("click", (el) => {
      if (el.target.getAttribute('type') !== 'radio') {
        el.target.parentElement.previousSibling.checked = true;
      }
      const acc = accounts[keys[document.querySelector('input[name="account"]:checked').value]];
      // if (acc.countLogin) acc.countLogin += 1;
      // else acc.countLogin = 1;
      // el.target.closest('div').querySelector('.h-badge').innerHTML = acc.countLogin;
      // el.target.closest('div').querySelector('.h-badge').classList.remove('hide');
      chrome.storage.sync.set({ 'checked': acc.username });
    });

    return div;
  }

  if (keys.length >= 10) {
    radioAccount.parentElement.style.width = '400px';

    const colum1 = document.createElement('div');
    const verticalLine = document.createElement('div');
    const colum2 = document.createElement('div');

    colum1.classList.add('column');
    colum2.classList.add('column');
    verticalLine.classList.add('vl');

    radioAccount.appendChild(colum1);
    radioAccount.appendChild(verticalLine);
    radioAccount.appendChild(colum2);

    const itemNumber = ~~(keys.length / 2);

    for (let i = 0; i < itemNumber; i++) {
      const key = keys[i];
      const acc = accounts[key];

      colum1.appendChild(renderRadio(acc, i, key));
    }
    for (let i = itemNumber; i < keys.length; i++) {
      const key = keys[i];
      const acc = accounts[key];

      colum2.appendChild(renderRadio(acc, i, key));
    }
  } else {
    for (let i = 0; i < keys.length; i++) {
      const key = keys[i];
      const acc = accounts[key];

      radioAccount.appendChild(renderRadio(acc, i, key));
    }
  }

})

const onClickLogin = (acc) => `
  logout = document.getElementsByClassName('ic-logout-c');
  if (logout.length === 0) {
    
    indentify = document.getElementById('signin-identity');
    password = document.getElementById('password');

    indentify.value = '${acc.username}';
    password.value = '${acc.password}';

    indentify.dispatchEvent(new Event('change'));
    password.dispatchEvent(new Event('change'));

    submit = document.querySelector('#signin button[type="submit"]');
  
    setTimeout(() => {
      submit.click();
    }, 0)
  } else {
    chrome.storage.sync.set({ 'account': {'username': '${acc.username}', 'password': '${acc.password}'} });

    logout[0].parentElement.parentElement.click();
  }
`;

const onClickAcceptFriend = () => `
  document.querySelector('#js-dropdown-notif-friend .dropdown-menu').classList.add('show');

  var addFriend = setInterval(function(){
    const notifList = document.querySelector('.notif-list');
    const btnAcceptFriend = notifList.querySelectorAll('.btn-friend.confirm');
    if (btnAcceptFriend.length === 0) {
        const btnLoadMore = notifList.nextElementSibling.nextElementSibling.getElementsByTagName('a');
        if (btnLoadMore.length === 0) {
            clearInterval(addFriend);
            alert('Đồng ý hết lời mời rồi nha bạn mình ơi !!');
            window.location.href = window.location.href;
        }
        else btnLoadMore[0].click();
    }
    btnAcceptFriend.forEach(function (a, b) { setTimeout(() => { a.click() }, b * 2000) })
  }, 1000);
`;

btnLogin.onclick = function () {
  let account = accounts[keys[document.querySelector('input[name="account"]:checked').value]];

  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    chrome.tabs.executeScript(
      tabs[0].id,
      { code: onClickLogin(account) });
  });
};

btnAcceptFriend.onclick = function () {
  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    chrome.tabs.executeScript(
      tabs[0].id,
      { code: onClickAcceptFriend() });
  });
};

btnReload.onclick = function () {
  chrome.runtime.reload();
};

btnShowPwd.onclick = function () {
  document.querySelectorAll('.pwd').forEach(function (item) {
    if (item.classList.contains('show')) {
      item.classList.add('hide');
      item.classList.remove('show');
      btnShowPwd.innerHTML = 'Show Pwd';
    } else {
      item.classList.add('show');
      item.classList.remove('hide');
      btnShowPwd.innerHTML = 'Hide Pwd';
    }
  })
};