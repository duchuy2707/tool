'use strict';

let btnLogin = document.getElementById('btnLogin');
let radioAccount = document.getElementById('radioAccount');
let accounts = {};
let keys = [];
let indentify, password, submit, logout = null;

chrome.storage.sync.get('accounts', function (data) {
  ({ accounts } = data);

  keys = Object.keys(accounts);

  for (let i = 0; i < keys.length; i++) {
    const key = keys[i];
    const acc = accounts[key];

    var input = document.createElement('input');
    input.setAttribute('type', 'radio');
    input.setAttribute('name', 'account');
    input.value = i;
    if (i === 0) input.checked = true;

    var label = document.createElement('label');
    label.innerHTML = '<span style="font-weight: bold;">' + key + '</span> <br/> <small style="font-style: italic;">' + acc.username + '</small>';

    var div = document.createElement('div');
    div.setAttribute('style', 'display: flex;');

    div.appendChild(input);
    div.appendChild(label);

    div.addEventListener("click", (el) => {
      el.target.parentElement.previousSibling.checked = true;
    });

    radioAccount.appendChild(div);
  }
})

const onClick = (acc) => `
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

btnLogin.onclick = function () {
  let account = accounts[keys[document.querySelector('input[name="account"]:checked').value]];

  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    chrome.tabs.executeScript(
      tabs[0].id,
      { code: onClick(account) });
  });
};