## YesMan141 Coffee
### ความเป็นมาของโปรแกรม
ส่วนตัวกระผมนั้นชื้นชอบในการดื่มกาแฟจึงได้ทอดลองสร้างโปรแกรมร้านกาแฟขึ้นมา
<br/><br/>
### วัตถุประสงค์ของโปรแกรม
พัฒนาขึ้นมาเพื่อใช้ในการศึกษาและเรียนรู้ในการเขียนโปรแกรมและเพื่อการพัฒนาในอนาคต


<br/><br/>
### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Program <|-- Form1
    Form1 <|-- Bill
    Program :+Main()
    class Form1{
        +button1_Click()
        +button2_Click()
        +button3_Click()
        +button4_Click()
        +loadProductFromFile()
        +button5_Click()
        + button6_Click()
    }
    class Bill{
        +Bill(string id, string menu, string price)

    }
```
<br/><br/>
### ผู้พัฒนาโปรแกรม
นายปรเมศวร์ สิทธิมงคล
643450078-5
