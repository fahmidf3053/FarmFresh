<template>
  <div class="grid">
    <a href="/products">On sales!</a>
    <a href="/products">New</a>
    <a href="/products">Shop by Store</a>
    <a href="/products">Fruit and Veg</a>
    <a href="/products">Meat & Seafood</a>
    <a href="/products">Dairy and Chilled</a>
    <a href="/products">Bakery</a>
    <a href="/products">Beverages</a>
    <a href="/products">Bakery</a>
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
