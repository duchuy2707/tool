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
- Cong cu tu dong cap nhat version moi
- Sort danh sach tai khoan
- Option show password
- Count account login

### Version 1.3.2
- update count login by day

### Version 1.4.1
- action request friend

### Version 1.4.2
- action request friend limit 50 post
- when load more 50 post, auto reload page

### Version 1.5.1
- send request add friend in tab friend of user
- update layout options

### Version 1.5.2
- limit click add friend in tab friend of user is 300

### Version 1.3.1
- Trang quan ly tai khoan
- Import file excel, json
- Export file json
- CRUD account

### Version xxx
- sau này có cần update thêm tài khoản nào đã vào rồi trong ngày, tài khoản nào chưa vào, tài khoản nào vào bao nhiu lần, tài khoản nào ưu tiên được đưa lên top, tài khoản nào độ ưu tiêp thấp ở dưới danh sách, chia ra loại tại khoản cá nhân tài khoản page tài khảon site này nọ hông

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