‎# تمرین ۶: JSON و XML

## JSON چیست؟

JSON (JavaScript Object Notation) فرمتی سبک برای ذخیره و انتقال داده به‌شکل «کلید: مقدار» است.

## XML چیست؟

XML (eXtensible Markup Language) فرمتی مبتنی بر تگ‌ها (شبیه HTML) برای ذخیره و انتقال داده است.

‎## کاربرد

‎هر دو برای تبادل داده بین برنامه‌ها، APIها، فایل‌های تنظیمات و ذخیره اطلاعات به‌کار می‌روند. امروز JSON در APIهای وب رایج‌تر است و XML بیشتر در سیستم‌های قدیمی‌تر دیده می‌شود.

‎## تفاوت‌ها

‎| ویژگی | JSON | XML |
|---|---|---|
‎| ساختار | کلید و مقدار | تگ باز و بسته |
‎| خوانایی و حجم | کوتاه‌تر و خواناتر | طولانی‌تر |
‎| سرعت | بیشتر | کمتر |
‎| کامنت | ندارد | دارد |
‎| آرایه | پشتیبانی مستقیم | پشتیبانی مستقیم ندارد |

‎## اطلاعات یک Student در JSON

```json
{
  "name": "Ali Rezaei",
  "studentId": "40212345",
  "major": "Computer Engineering",
  "gpa": 18.5,
  "courses": ["OOP", "Database", "Web"]
}
```

‎## اطلاعات یک Student در XML

```xml
<student>
  <name>Ali Rezaei</name>
  <studentId>40212345</studentId>
  <major>Computer Engineering</major>
  <gpa>18.5</gpa>
  <courses>
    <course>OOP</course>
    <course>Database</course>
    <course>Web</course>
  </courses>
</student>
```
