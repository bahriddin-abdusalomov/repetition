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

# Natija 

```
                     ProductID   SaleDate    Revenue
                     1           2023-01-01  100.00
                     1           2023-01-02  150.00
                     2           2023-01-01  200.00
                     2           2023-01-02  250.00                                                                               
```

```
        SELECT * FROM ( SELECT ProductID, SaleDate, Revenue FROM Sales) AS SourceData
         PIVOT ( SUM(Revenue) FOR SaleDate IN ([2023-01-01], [2023-01-02])) AS PivotTable;                      
```

# Natija

```
                     ProductID   2023-01-01  2023-01-02
                     1           100.00      150.00
                     2           200.00      250.00                                                                     
```
