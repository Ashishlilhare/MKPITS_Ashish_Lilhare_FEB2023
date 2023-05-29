select p.productid,p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID  
where t.Product_Type_Name = 'Computer';