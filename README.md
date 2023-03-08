#FarmFresh

> An online supermarket offering a huge range of grocery products.
>  Developed with ASP.NET Core MVC &&  Vue.js

## To run the frontend of FarmFresh, please go to the FarmFresh-Frontend

``` bash
# Open the project folder
cd Vue-Ecom && npm install

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

#API documentation

## Name: Authenticate
``` bash
#### Authorization: 
none
#### Request Body:
Type: JSON
Required: Yes
Example:
{
  "name": "username",
  "password": "xxxxxx"
}
#### Response:
Status: 200 for Success
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImZhcm1mcmVzaCIsIm5iZiI6MTY3ODI1MDEyMCwiZXxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
    "refreshToken": null
}
```
