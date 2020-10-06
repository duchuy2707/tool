'use strict';

let btnLogin = document.getElementById('btnLogin');
let btnAcceptFriend = document.getElementById('btnAcceptFriend');
let btnRequestFriend = document.getElementById('btnRequestFriend');
// let btnReload = document.getElementById('btnReload');
let radioAccount = document.getElementById('radioAccount');
let btnShowPwd = document.getElementById('btnShowPwd');
let spanToday = document.getElementById('today');

let accounts = {};
let keys = [];
let isToday = false;
let indentify, password, submit, logout, checked, oldDay, arrPost, timePost = null;
let indexPost = 0;

let today = new Date().toISOString().slice(0, 10);
spanToday.innerHTML = today;

chrome.storage.sync.get(['accounts', 'checked', 'keys', 'oldDay'], function (data) {
  ({ accounts, checked, keys, oldDay } = data);

  if (!oldDay || today !== oldDay) {
    isToday = false;
    chrome.storage.sync.set({ 'oldDay': today });
  } else isToday = true;

  const renderRadio = (acc, i, key) => {
    if (!isToday) acc.countLogin = 0;

    var input = document.createElement('input');
    input.setAttribute('type', 'radio');
    input.setAttribute('name', 'account');
    input.classList.add('selectRadio');
    input.value = i;
    if (checked === acc.username) input.checked = true;
    else if (i === 0) input.checked = true;

    var label = document.createElement('label');
    label.innerHTML = '<span class="selectRadio" style="font-weight: bold;">' + key + '</span> <span class="selectRadio h-badge ' + (acc.countLogin ? '' : 'hide') + '">' + acc.countLogin + '</span> <br/> <small class="selectRadio" style="font-style: italic;">' + acc.username + '</small> <br/> <small class="selectRadio pwd hide" style="font-style: italic">' + acc.password + '</small>';

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
            window.location.reload();
        }
        else btnLoadMore[0].click();
    }
    btnAcceptFriend.forEach(function (a, b) { setTimeout(() => { a.click() }, b * 2000) })
  }, 1000);
`;

/**
 * find bài post
 * tìm tới list danh sách người reaction
 * click mở modal danh sách người reaction
 * tìm những bạn bè nào có nút add friend để gởi lời mời
 * ấn load more cho tới hết
 * ẩn modal tìm tới bài post tiếp theo
 * nếu không có ai reaction thì bỏ qua
 * đợi danh sách bạn bè load ra bằng hàm interval
 * tự scroll tới cuối để load thêm bài post
 * chỉ dừng lại khi reload
 */
const onClickRequestFriend = () => `
  const getPost = (i = 0) => {
    arrPost = document.querySelectorAll('.post');

    indexPost = i;

    timePost = setInterval(() => {
      if (indexPost === arrPost.length) {
        clearInterval(timePost);
        window.scrollTo(0, document.body.scrollHeight);

        setTimeout(() => {
          let timeLoadingPost = setInterval(() => {
            if (document.querySelectorAll('.act-post-loading').length === 0) {
              clearInterval(timeLoadingPost);
              if (indexPost > 50) window.location.reload();
              else getPost(indexPost);
            }
          }, 100);
        }, 1000);

      } else {
        let modalReaction = document.getElementById('modal__reaction-count');
        if (!modalReaction || !modalReaction.classList.contains('show')) {
          const btnReaction = arrPost[indexPost].querySelector('.post-statistic__reaction');
          indexPost++;
          if ((btnReaction.querySelector('[data-bind="text: messLike"]').innerHTML || '').length > 0) {
            btnReaction.click();

            if (!modalReaction) modalReaction = document.getElementById('modal__reaction-count');

            setTimeout(() => {
              if (modalReaction.classList.contains('show')) {
                let timeoutClickAddFriend = [];
                const clickToAddFriend = () => {
                  var loadingTime = setInterval(() => {
                    if ((document.getElementById('data-loading-content-reaction').innerHTML || '').length === 0) {
                      clearInterval(loadingTime);

                      const arrUserReaction = modalReaction.querySelectorAll('.list-user__item');
                      let index = 0;
                      arrUserReaction.forEach(function (a) {
                        const btnAddFr = a.querySelectorAll('.btn-friend.add');
                        if (btnAddFr.length > 0) {
                          timeoutClickAddFriend.push(setTimeout(() => {
                            btnAddFr[0].click()
                          }, index * 2000));
                          index++;
                        }
                      });

                      const btnLoadMore = modalReaction.querySelectorAll('[data-bind="click: onShowMore"]');
                      if (btnLoadMore.length > 0) {
                        btnLoadMore[0].click();
                        clickToAddFriend();
                      } else {
                        setTimeout(() => {
                          document.getElementById('modal__reaction-count').querySelector('[data-dismiss]').click();
                        }, timeoutClickAddFriend.length === 0 ? 0 : timeoutClickAddFriend.reduce((a, b) => a + b) + 1000);
                      }
                    }

                  }, 100);
                }

                clickToAddFriend();
              }
            }, 1000);
          }
        }
      }
    }, 1000);
  }

  getPost();
`;

btnLogin.onclick = function () {
  const rdo = document.querySelector('input[name="account"]:checked');
  let account = accounts[keys[document.querySelector('input[name="account"]:checked').value]];

  if (account.countLogin) account.countLogin += 1;
  else account.countLogin = 1;

  rdo.closest('div').querySelector('.h-badge').innerHTML = account.countLogin;
  rdo.closest('div').querySelector('.h-badge').classList.remove('hide');

  chrome.storage.sync.set({ accounts });

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

btnRequestFriend.onclick = function () {
  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    chrome.tabs.executeScript(
      tabs[0].id,
      { code: onClickRequestFriend() });
  });
};

// btnReload.onclick = function () {
//   chrome.runtime.reload();
// };

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