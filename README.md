# FarmFresh


> An online supermarket offering a huge range of grocery products.
>  Developed with ASP.NET Core MVC &&  Vue.js.

## Architecture Diagram of FarmFresh


<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/Architecture.png">
</p>


## To run the frontend of FarmFresh, please go to the FarmFresh-Frontend


``` bash
# Open the project folder
cd FarmFresh-Frontend && npm install

# FOR DEV: If you have **vue/cli 3** then through **vue ui** you can import the file and serve it. else 
npm run serve

# FOR BUILD: 
npm run build
```

## Landing Page
<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/ScreenShots/landingpage.PNG">
</p>

## Promotional Page
<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/ScreenShots/promopage.PNG">
</p>

## Product List Page
<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/ScreenShots/shopping.PNG">
</p>

## Product Detail Page
<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/ScreenShots/productpage.PNG">
</p>

## Search
<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/ScreenShots/searchpage.PNG">
</p>

## To run the backend of FarmFresh, please go to the FarmFreshApiService and Database Scripts will be found under DBScripts Folder



### After running the FarmFreshApiService, following apis will be available
<p align="center">
  <img src="https://github.com/fahmidf3053/FarmFresh/blob/main/Documents/ScreenShots/apilist.PNG">
</p>

# API documentation



## Name: /Authenticate
``` bash
-> Method type: POST
-> Authorization: none
-> Params: none
-> Request Body:
   -> Type: JSON
   -> Required: Yes
   -> Example: {
                  "name": "username",
                  "password": "xxxxxx"
               }
-> Response:
   -> Status: 200 for Success
   -> Example: {
                 "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImZhcm1mcmVzaCIsIm5iZiI6MTY3ODI1MDEyMCwiZXxxxxxxxxxxxxxxxxxxx",
                 "refreshToken": null
               }
```

## Name: /GetAllProducts
``` bash
-> Method type: GET
-> Authorization: Bearer Token (You can get token by calling Authenticate API. Each token is valid for 10 minutes)
-> Params: 
    ---------------------------------------------------------------
    Name      -  Type  -  Required -          Description
    ---------------------------------------------------------------
    ---------------------------------------------------------------
    pageSize  -   int  -   No     - No of entry you want in a page.
    ---------------------------------------------------------------
    pageNumber -  int  -   No     - page no you want to see.
    ---------------------------------------------------------------
-> Request Body: none
-> Response:
   -> Status: 200 for Success
   -> Type: JSON Array (List of Product)
   -> Example: [
                {
                  "id": 1,
                   "name": "Ripe Blue Grape",
                   "about": "From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes.",
                   "price": 200.00,
                   "type": "Packet",
                   "image": "grape.png",
                   "origin": "France"
               },
               {
                  "id": 2,
                  "name": "Salmon",
                  "about": "From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes.",
                  "price": 300.00,
                  "type": "Packet",
                  "image": "salmon.png",
                  "origin": "USA"
               }
              ]
```

## Name: /GetProductByName
``` bash
-> Method type: GET
-> Authorization: Bearer Token (You can get token by calling Authenticate API. Each token is valid for 10 minutes)
-> Params: 
    ---------------------------------------------------------------
    Name      -  Type  -  Required -          Description
    ---------------------------------------------------------------
    ---------------------------------------------------------------
    name      - string -   Yes    - Name of the Product.
    ---------------------------------------------------------------
    pageSize  -   int  -   No     - No of entry you want in a page.
    ---------------------------------------------------------------
    pageNumber -  int  -   No     - page no you want to see.
    ---------------------------------------------------------------
-> Request Body: none
-> Response:
   -> Status: 200 for Success
   -> Type: JSON Array (List of Product)
   -> Example: [               
                {
                  "id": 2,
                  "name": "Salmon",
                  "about": "From the heart of the french Alps after a journey of more than 70 years, springs this Ripe Blue Grapes.",
                  "price": 300.00,
                  "type": "Packet",
                  "image": "salmon.png",
                  "origin": "USA"
               }
              ]
```
