<template>
  <div class="wrapper">
      <div class="divgrid">
        <Grid/>
      </div>
      <div class="divproduct">
        <div v-if="products.length == 0" class="text-center my-5">
          <img src="@/assets/noproductfound.png" height="50%" width="50%">
        </div>
        <Card v-else :Products="products" />
      </div>
  </div>
</template>

<script>
import Grid from './Grid.vue'
import Card from './Card.vue'
import axios from 'axios'

export default {
  name: 'ProductPage',
  components: {
    Grid, Card
  },
  data() {
    return {
      products: []
    }
  },
  created(){
    //this.products = this.it
    //console.log(this.products)
  },
  mounted(){
      this.getProductByName(this.$route.params.name); 
  },
  computed: {
    it(){
      return this.$store.state.items
    },
    slicedproducts(){
      return this.products.slice(0, this.showproducts)
    }
  },
  methods: {
    async getAllProducts() {
      try {     
        const headers = { 'Authorization': 'Bearer '+this.$store.state.token};  
        const res = await axios.get(
          `${process.env.VUE_APP_FARMFRESH_API_URL}GetAllProducts?pageSize=0&pageNumber=0`,
            {headers}
          
        );
        this.products = res.data;       
      } catch (error) {
        console.log(error);
      }
    },
    async getProductByName(name) {
      try {
          if(name == 'all' || name == '')
          {
            this.getAllProducts();
          }
          else
          { 
            const headers = { 'Authorization': 'Bearer '+this.$store.state.token};
            const res = await axios.get(
              `${process.env.VUE_APP_FARMFRESH_API_URL}GetProductByName?name=${name}&pageSize=0&pageNumber=0`,
              {headers}
              
            );
            this.products = res.data; 
          }      
      } catch (error) {
        console.log(error);
      }
    },
  }
}
</script>

<style scoped>

.wrapper {
  display: flex;
  justify-content: space-between;
}

.divgrid{
  width: 25%;
  height: 100%;
  position: -webkit-sticky;
  position: sticky;
  top: 17%;
}

.divproduct{
  width: 75%;
}
</style>
