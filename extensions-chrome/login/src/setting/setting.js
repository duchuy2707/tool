/**
 * @author duchuy
 */

'use strict';

const body = document.getElementById('table-account-body');
const btnSave = document.getElementById('btnSave');
const btnReload = document.getElementById('btnReload');
const btnShowPwd = document.getElementById('btnShowPwd');

chrome.storage.sync.get(['accounts', 'keys'], function (data) {
  const { accounts, keys } = data;

  for (let i = 0; i < keys.length; i++) {
    const key = keys[i];
    const acc = accounts[key];

    const tr = document.createElement('tr');

    const tdStt = document.createElement('td');
    tdStt.innerHTML = i + 1;

    const tdName = document.createElement('td');
    tdName.innerHTML = key;

    const tdUsername = document.createElement('td');
    tdUsername.innerHTML = acc.username;

    const tdPwd = document.createElement('td');
    tdPwd.classList.add('pwd', 'hide');
    tdPwd.innerHTML = acc.password;

    tr.appendChild(tdStt);
    tr.appendChild(tdName);
    tr.appendChild(tdUsername);
    tr.appendChild(tdPwd);

    body.appendChild(tr);
  }

  btnSave.onclick = function () {
    document.execCommand('SaveAs', null, filename)
  };

  btnReload.onclick = function () {
    chrome.runtime.reload();
  };

  btnShowPwd.onclick = function () {
    console.log();
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
})
