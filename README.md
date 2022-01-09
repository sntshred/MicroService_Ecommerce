# MicroService_Ecommerce
![image](https://user-images.githubusercontent.com/9728497/147839730-b1cd8693-fa0b-4a24-bae0-85c799ce2309.png)

1. Create a blank project in Src folder
2. Create a new solution folder **Services**  - Will create Microservices under this folder
3. Create a new **Catlog solution folder** underneath
4. Create a new project with the below filepath to **create physical folder "src/services/catalog/Catalog.API"**
5. Change project properties 
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
 22. **note:** Create Repostiory pattern to encapsulate **datacontext** object, by this way there's a abstraction with the repository layer
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
---
### Basket.API Microservice

1. Right click on services foler, Create "Basket" solution folder
2. Right click on Basket folder to add new project 
 ![image](https://user-images.githubusercontent.com/9728497/147376639-4228d1bb-46f0-480d-a674-412be4445db9.png)
3. Select "Web.api" template, create a physical folder by "**adding the folder on the**" as below
![image](https://user-images.githubusercontent.com/9728497/147376662-b88a4529-03c0-4953-81a9-b2e741499609.png)
4. **Note:** Redis exteremely fast because it works synchronously
5. docker pull redis
6. docker run -d -p 6379:6379 --name aspnetrun-redis redis
7. troubleshooting in docker: docker logs -f aspnetrun-redis
8. intercative terminal: docker exec -it aspnetrun-redis /bin/bash
10. In the interactive window, to check the Redis working, we need to go to** redis cli**
11. type **redis-cli** command
12. ping (response ==> pong)
13. ![image](https://user-images.githubusercontent.com/9728497/147376836-c9c9e0bf-ce6a-47b7-bb51-2fb87f813dae.png)
14. will store the basket values in json object in Redis cache, for each user, has a key
15. Download "Microsoft.Extensions.Caching.StackExchangeRedis"
16. In **Stratup.cs** file  services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration.GetValue<string>("CacheSettings:ConnectionString");
            });
17. "set <usernmae> <Basket JSON object>"
18. Create Repository folder
    - IBasketRepository.cs
19. sample data to post on Redis
  "userName": "swn",
  "items": [
    {
      "quantity": 2,
      "color": "Red",
      "price": 500,
      "productId": "602d2149e773f2a3990b47f5",
      "productName": "IphoneX"
    },
  
  20. docker exec -it aspnetrun-redis /bin/bash
  30. redis-cli to check the username and the values on docker container
  31.docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
  
  ----
  
  ## Container Mangement with  **Portainer**
  https://docs.portainer.io/v/ce-2.11/start/install/server/docker/linux#deployment
  https://hub.docker.com/r/portainer/portainer-ce
  
  After configuring the portainer, goto localhost:9000, and set the password
  uername: admin
  password: password
  ![image](https://user-images.githubusercontent.com/9728497/147434887-7a8635b8-0357-4552-9090-67d66f71bc49.png)
  
  ----
  ## Discount API
  
 1. Right click on services foler, Create "Discount" solution folder
 2. Right click on Discount folder to add new project 
 3. 1https://hub.docker.com/_/postgres
 4. https://hub.docker.com/r/dpage/pgadmin4
 5. https://www.pgadmin.org/docs/pgadmin4/latest/container_deployment.html
 ![image](https://user-images.githubusercontent.com/9728497/147514029-a7a34f55-6688-4fca-8d24-2eaaeb263656.png)

  
  ----
  
  ## Discount API With GRPC
  
  ![image](https://user-images.githubusercontent.com/9728497/147703947-a59efc5f-3981-4146-9a7c-9625bc976a1a.png)

  ![image](https://user-images.githubusercontent.com/9728497/147703920-88871b4d-e86f-42af-9c0b-ea431aac06cf.png)
  
  We need to select GRPC template
  ![image](https://user-images.githubusercontent.com/9728497/147705024-8f76b575-a5c2-4c2d-96a5-b0692ed9a297.png)

  
  1. Protos/ greet.proto-- comes for the GRPC services
  2. We need to **create and expose Discount proto** to Basket API
  3. - **Build Action:** Protobuf compiler will convert proto to charp class for client application
     - **gRPC: Server Only:** we exposes greet.proto file to external systems <br />
      ![image](https://user-images.githubusercontent.com/9728497/147706258-92755274-a042-404f-bded-99e5bb8f2330.png)
  
  After changing the confiuration, we can verify in the project file <br />
   ![image](https://user-images.githubusercontent.com/9728497/147706522-7764cb80-0093-46e2-aeb6-4d51e6f0e7cd.png) <br />
  4. **Services/GreeterService:** which perform GRPC connection  <br />
  5. Startup.cs <br />
  ![image](https://user-images.githubusercontent.com/9728497/147705531-21f867ba-7180-4108-979e-7b3192906d58.png) <br />
  6. **Note**: Normally we expose API from the **controller classes** in **API project**, but, for this time for the **gRPC**, we need to create **proto** service classes.
  EG: DiscountController == DiscountServices (in gRPC)

  7. create "DiscountProto" <br />
  ![image](https://user-images.githubusercontent.com/9728497/147709167-ad9beb93-c98a-477e-8a41-3ca9f8b141e1.png)
  8. Right click on DiscountProto, and add configure "Build Action" and **gRPC stub class** to Server only<br />
  ![image](https://user-images.githubusercontent.com/9728497/147710446-c2b60120-c30b-4a82-92e3-1c1d9b11b96e.png) <br />
  9. Create Service/DiscountService.cs file and convert to proto file by inhertiance 
   public class DiscountService: DiscountProtoService.DiscountProtoServiceBase
  10. Expose Grpc service as below in startup class
  ![image](https://user-images.githubusercontent.com/9728497/147839037-3bfb3a12-176f-450b-8df9-b73f69ab16aa.png)

  ---
  **Consuming Discoung Grpc service from Basket microservice** -- When Adding Cart item into Shopping cart to Calculate Final price
  ![image](https://user-images.githubusercontent.com/9728497/147839729-4f1bbb18-1ab4-42c8-b065-b8d2dbfcbd4b.png)
  
  1. Communicate with Discount.Grpc
  2. Calculate latest price of product into shopping cart
  3. "Basket API" will be client of **Discount.gRpc **
   BasketAPi (clinet gRpc) == Discount.gRpc (Server gRpc)
  4. User connected service of visual studio to setup communicatiion between thsi projects
  ![image](https://user-images.githubusercontent.com/9728497/147840005-e23f8498-78f6-4e38-ba7d-55fd0ae544d1.png)
  5.<br /> ![image](https://user-images.githubusercontent.com/9728497/147840181-3153f5d3-7ccb-40f4-986c-8ac5b8046247.png) <br />
  6. Select type of the class to be generated: **Client**
  - Because we are going to consume this "gRpc" method

  ---
  ## Ordering Microservices
  
  ![image](https://user-images.githubusercontent.com/9728497/147957856-576ecdc4-ab4d-45a5-ba28-d61593fb7694.png)
  
  ![image](https://user-images.githubusercontent.com/9728497/147959172-8254d64c-d82c-475f-9ffb-1d62203ca36e.png)

  ![image](https://user-images.githubusercontent.com/9728497/147959701-66c67970-a9ef-440d-a707-1d379a80b212.png)
   
   https://medium.com/software-alchemy/a-brief-intro-to-clean-architecture-clean-ddd-and-cqrs-23243c3f31b3
  
  ![image](https://user-images.githubusercontent.com/9728497/147961873-245cd7ea-4684-45b6-8230-3a2de7413129.png)

  ![image](https://user-images.githubusercontent.com/9728497/148326655-9e00b45c-2d2b-40b1-823a-529354291470.png)

  1. If there's no response type, the return type expected by Mediator is "Unit"
  public Task<**Unit**> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
  
  2.     // UpdateOrderCommand --> which means we are validating updateordercommand, we saying specifying the type
    public class UpdateOrderCommandValidator: AbstractValidator<**UpdateOrderCommand**>
    {

    }
  
  3. Exception handler to specify every layer has a different exception using "Exceptions/ExceptionHandler", we customize exception by different layers using below
  4. Any validations fail occurs in update/delete,checkout validattor you can capture by this method.
   
  public ValidationException(IEnumerable<ValidationFailure> failures)
        : this()
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }

  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  





  
  
  
  
  
  
  
  

  
  
  
  
  
  
 
  
  





 

      
     
 
 

 
  


