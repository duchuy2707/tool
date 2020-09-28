console.log('init');

chrome.storage.sync.get('accounts', function (data) {
    const { accounts } = data;
    console.log(accounts);
})

chrome.extension.onMessage.addListener(
    function (request, sender, sendResponse) {
        // LOG THE CONTENTS HERE
        console.log(request.content);
    }
);