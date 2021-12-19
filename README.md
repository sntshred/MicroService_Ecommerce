# MicroService_Ecommerce

1. Create a blank project in Src folder
2. Create a new solution folder **Services**  - Will create Microservices under this folder
3. Create a new **Catlog solution folder** underneath 
4. Change project properties 
![image](https://user-images.githubusercontent.com/9728497/146467183-5d154629-89ef-41be-b3b4-651b87216fe2.png)
5. Setup **MongoDB using Docker**
6. Docker pull mongo (pull mongo image)
7. docker run -d -p 27017:27017 --name shopping-mongo mongo
8. docker logs -f shopping-mongo
9. docker exec -it shopping-mongo /bin/bash (Inside the docker container)
  - mongo
  - show dbs
10. use CatalogDb  (creates CatalogDb if not present and switches)
11.  db.createCollection('Products')
12.  db.Products.insertMany( [ { "Name":"Asus Laptop", "Category":"Compouters", "Summary":"Summary", "ImageFile":"ImageFile", "Price":54.93 }, { "Name":"Dell Laptop", "Category":"Compouters", "Summary":"Summary", "ImageFile":"ImageFile", "Price":54.93 }, { "Name":"Mac Laptop", "Category":"Compouters", "Summary":"Summary", "ImageFile":"ImageFile", "Price":54.93 }, { "Name":"Microsoft Laptop", "Category":"Compouters", "Summary":"Summary", "ImageFile":"ImageFile", "Price":54.93 } ])
13.  db.Products.find({}).pretty()
14.   db.Products.remove({})
15.   show collections
16.   ![image](https://user-images.githubusercontent.com/9728497/146679606-41b13385-afda-48a6-8105-ff5d9b8401ea.png)
17.   


