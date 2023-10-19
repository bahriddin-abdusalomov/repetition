# SQL SERVER => PIVOT 
 Qator qiymatlarini bir nechta ustunlarga aylantirish orqali jadvaldagi satrlarni aylantirish uchun PIVOT dan foydalanishingiz mumkin.
 Quyidagi diagramma PIVOT nima qilishi mumkinligini ko'rsatadi, bu erda biz 4 qator ma'lumotlarni olib, uni 4 ta ustunli 1 qatorga aylantiramiz. 
 Ko'rib turganingizdek, PIVOT jarayoni jadvalni burish orqali satrlarni ustunlarga aylantiradi.

# ![image](https://github.com/bahriddin-abdusalomov/repetition/assets/123171397/7ee8ad89-b66a-4270-aabd-21b679b4081f)

# Exmaple 

```
            CREATE TABLE Sales ( ProductID INT, SaleDate DATE, Revenue DECIMAL(10, 2));                     
            
            INSERT INTO Sales (ProductID, SaleDate, Revenue) VALUES                                  
                (1, '2023-01-01', 100.00),  (1, '2023-01-02', 150.00),
                (2, '2023-01-01', 200.00),  (2, '2023-01-02', 250.00);                                                 
```

                       ![image](https://github.com/bahriddin-abdusalomov/repetition/assets/123171397/51669670-83df-4f7d-8df2-27fb36ac6489)


