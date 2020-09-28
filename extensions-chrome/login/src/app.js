chrome.runtime.onInstalled.addListener(function () {
    var xhr = new XMLHttpRequest;
    xhr.open("GET", chrome.runtime.getURL('../data/account.json'));
    xhr.onreadystatechange = function () {
        if (this.readyState == 4) {
            chrome.storage.sync.set({ accounts: JSON.parse(xhr.responseText) }, function () {
                console.log("setting data done");
            });
        }
    };
    xhr.send();

    chrome.declarativeContent.onPageChanged.removeRules(undefined, function () {
        chrome.declarativeContent.onPageChanged.addRules([{
            conditions: [new chrome.declarativeContent.PageStateMatcher({
                pageUrl: { hostEquals: 'hahalolo.com' },
            })
            ],
            actions: [new chrome.declarativeContent.ShowPageAction()]
        }]);
    });
});