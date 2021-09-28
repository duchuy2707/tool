'use strict';

const btnReload = document.getElementById('btnReload');
const btnUnsafe = document.getElementById('btnUnsafe');
const listDomains = document.getElementById('listDomains');
let domains = [];
let indexSelected;

const createDomainInputRadio = (element, index) => {
  const div = document.createElement('div'), input = document.createElement('input'), label = document.createElement('label');

  input.setAttribute('type', 'radio');
  input.setAttribute('name', 'account');
  input.classList.add('selectRadio');
  input.value = index;

  label.innerHTML = '<span class="selectRadio" style="font-weight: bold;color: red">' + element.projectName + '</span> : <span class="selectRadio" style="font-weight: bold;">' + element.path + '</span>';
  label.classList.add('selectRadio');

  div.setAttribute('style', 'display: flex;');
  div.appendChild(input);
  div.appendChild(label);
  div.classList.add('pathRadio');

  div.addEventListener("click", (el) => {
    let radio;
    if (el.target.getAttribute('type') !== 'radio') {
      if (el.target.classList.contains('pathRadio')) radio = el.target.firstChild;
      else if (el.target.tagName === 'LABEL') radio = el.target.previousSibling;
      else radio = el.target.parentElement.previousSibling;
      radio.checked = true;
      indexSelected = radio.value;

      btnUnsafe.classList.remove('disable');
    }
  });

  listDomains.appendChild(div);
}

chrome.storage.sync.get(['domains'], function (data) {
  ({ domains } = data);

  listDomains.parentElement.style.width = '450px';

  domains.forEach((element, index) => {
    createDomainInputRadio(element, index);
  });
});

btnReload.onclick = function () {
  chrome.runtime.reload();
};

const onUnsafe = (link) => `
 window.location.href = '${link}';
//  document.getElementById('details-button').click();
`;

btnUnsafe.onclick = function () {
  // window.open(domains[indexSelected].path);

  chrome.tabs.query({ active: true, currentWindow: true }, function (tabs) {
    chrome.tabs.executeScript(
      tabs[0].id,
      { code: onUnsafe(domains[indexSelected].path) });
  });
};

// chrome.action.onClicked.addListener((tab) => {
//   chrome.scripting.executeScript({
//     target: { tabId: tab.id },
//     files: ['content-script.js']
//   });
// });