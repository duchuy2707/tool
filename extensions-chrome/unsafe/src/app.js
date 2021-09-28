chrome.runtime.onInstalled.addListener(function () {
    var xhr = new XMLHttpRequest;
    xhr.open("GET", chrome.runtime.getURL('../data/domains.json'));
    xhr.onreadystatechange = function () {
        if (this.readyState == 4) {
            const domains = JSON.parse(xhr.responseText);
            chrome.storage.sync.set({ domains });
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