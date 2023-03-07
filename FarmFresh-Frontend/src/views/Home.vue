<template>
  <div>
    <LandingPage/>
  </div>
</template>

<script>
import LandingPage from '@/Components/HomePage/LandingPage.vue'

export default {
  components: {
  LandingPage
  },
  data(){
    return {
      pageRefreshed: true
    }
  },
  created() {
      this.authenticate();
      if (!this.$isServer) {
        window.addEventListener('scroll', this._scrollListener)
      }
      this.pageRefreshed = false;
  },
  beforeDestroy() {
      window.removeEventListener('scroll', this._scrollListener)
  },
  methods: {
    _scrollListener ()  {
          var currentScrollPosition = window.scrollY

          if(currentScrollPosition < this.scrollPosition){
            //console.log("Scrolling up");
          }
          else if(currentScrollPosition > this.scrollPosition && !this.pageRefreshed){           
            this.$router.push({ path: 'info' })
          }

          this.scrollPosition = window.scrollY
    },
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

<style scoped>


</style>
