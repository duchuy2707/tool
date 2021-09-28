chrome.storage.sync.get('domains', function (data) {
    const { domains = {} } = data;

    // console.log('\n--------\n', domains, '\n--------\n');
    if (document.getElementById('details-button')) document.getElementById('details-button').click();
});