<template>
  <div class="grid">
    <a href="/products/all">On sales!</a>
    <a href="/products/all">New</a>
    <a href="/products/all">Shop by Store</a>
    <a href="/products/all">Fruit and Veg</a>
    <a href="/products/all">Meat & Seafood</a>
    <a href="/products/all">Dairy and Chilled</a>
    <a href="/products/all">Bakery</a>
    <a href="/products/all">Beverages</a>
    <a href="/products/all">Bakery</a>
  </div>
</template>

<script>


export default {
  name:'Grid',
  methods: {
    
  }
  }
</script>

<style>

.grid {
  display:flex;
  flex-direction:column;
  gap: 1.5rem;
  padding: 50px;
  background-color: #ecf0f1;
  height: 83vh;
}

.grid a {
   font-weight: bold;
   text-decoration: none !important;
   color: #666666;
   width: 100%;
}
.grid a:hover {
  color: #ffffff;
  background-color: #a89d9d;
}

</style>
