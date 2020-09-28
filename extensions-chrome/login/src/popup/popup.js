'use strict';

let btnLogin = document.getElementById('btnLogin');
let radioAccount = document.getElementById('radioAccount');

chrome.storage.sync.get('accounts', function (data) {
  const { accounts } = data;

  const keys = Object.keys(accounts);

  for (let i = 0; i < keys.length; i++) {
    const key = keys[i];
    const acc = accounts[key];

    var input = document.createElement('input');
    input.setAttribute('type', 'radio');
    input.setAttribute('name', 'account');
    input.value = i;

    var label = document.createElement('label');
    label.innerHTML = '<span>' + key + '</span> <br/> <small>' + acc.username + '</small>';

    var div = document.createElement('div');
    div.setAttribute('style', 'display: flex;');

    div.appendChild(input);
    div.appendChild(label);

    radioAccount.appendChild(div);
  }
})

btnLogin.onclick = function () {
  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    chrome.tabs.executeScript(
      tabs[0].id,
      { file: '/login.js' });
  });
};