# tool
Tào lao tool

### Version 1.1.1
- Load danh sach account tu file json
- Chon tai khoan login
- Logout

### Version 1.2.1
- Chia cot cho popup danh sach tai khoan
- chon lai tai khoan da chon truoc do
- tinh nang tu dong y loi moi ket ban

### Version 1.3.1
- Trang quan ly tai khoan
- Import file excel, json
- Export file json
- CRUD account

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