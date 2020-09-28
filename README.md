# tool
Tào lao tool

### Version 1.1.1
- Load danh sach account tu file json
- Chon tai khoan login
- Logout

####  Chay ngam js
``` javscript
"content_scripts": [
  {
    "matches": [
      "*://www.hahalolo.com/*"
    ],
    "js": [
      "src/popup/login.js"
    ]
  }
]
```