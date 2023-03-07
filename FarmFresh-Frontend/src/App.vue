<template>
  <div id="app">
      <Header/>
      <transition
         mode="out-in"
        enter-active-class="animate__animated animate__fadeInUp"
        leave-active-class="animate__animated animate__fadeOutUp"
        >
          <router-view />
      </transition>
  </div>
</template>

<script>
import Header from '@/Components/Header.vue'
import axios from 'axios'

export default{
  name: 'app',
  components: {
    Header
  },
  data: function() {   
    return {
      
    };
  },
  mounted(){
    this.authenticate();
  },
  methods: {
    async authenticate() {
      try {   
        const user = {
          name: process.env.VUE_APP_USERNAME,
          password: process.env.VUE_APP_PASS
        }
        
        const res = await axios.post(
          `${process.env.VUE_APP_FARMFRESH_API_URL}Authenticate`,
          user      
        );
        this.$store.commit('updateToken', res.data.token);

      } catch (error) {
        console.log(error);
      }
    },
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css?family=Exo+2');
#app {
  background-color: #F8F8F8 !important;
  font-family: 'Exo 2', sans-serif !important;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
</style>
