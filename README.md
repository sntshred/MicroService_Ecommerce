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
16. <br />   ![image](https://user-images.githubusercontent.com/9728497/146679651-367d31b2-fd09-4001-8b33-e7bf09909233.png)
17. <br /> ![image](https://user-images.githubusercontent.com/9728497/146679896-c15b70e4-feb3-4ac1-a258-2a9718fdab5a.png)
18.  <br /> ![image](https://user-images.githubusercontent.com/9728497/146679987-fa711000-9844-472e-9379-46087368e24a.png)
19. < br /> ![image](https://user-images.githubusercontent.com/9728497/146680054-8b095dba-7f2f-4fa1-9c9d-b34cfbf842d3.png)
20. Create Entiites (Folder) for  **Products**
21.  Create a Data folder (DAL)
  -  Create ICatalogContext
  -  Create CatalogContext
  -  Create CatalogContextSeed
 22. **note:** Create Repostiory pattern to encapsulate **datacontext** object, by this way there's a abstreaction with the repository layer
 23.   Create *Repositories folder"
      - create IProductRepository
      - ProductRepository
 24. Create Presnation Layer 
      - creating controller class
      -  Controller/CatalogController.cs
      -  Note: inside the **presentaion layer**, will using busienss logic layer which is **repository layer**
 25.  Create docker continer of Catalog API <br />
 ![image](https://user-images.githubusercontent.com/9728497/146694239-793dbc41-c5f9-48b2-aa8d-ccac2a3e3476.png)
  - Select Linux as operating system
 26. Adding MongoDb image into Docker-Compose File for Multi-Container Docker Environ
 27. docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
 28. - note: when the profile in vs 2019  set to "Docker compose", build and clean on vs 2019 will do the docker operations, such has "clean solution", will stop the container and removes the container, so to avoid that, update the below configuration on vs 2019.
  ![image](https://user-images.githubusercontent.com/9728497/146697451-db23924b-28cf-42aa-9fa2-2eb157d9d4dc.png)
29. Mongo GUI Options for MongoDb Docker Image
- docker run -d -p 3000:3000 mongoclient/mongoclient
31. 
 

      
     
 
 

 
  


