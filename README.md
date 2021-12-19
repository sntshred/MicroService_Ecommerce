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
  -- mongo
  -- show dbs
11. 

