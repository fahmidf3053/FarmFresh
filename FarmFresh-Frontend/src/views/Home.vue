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
    }
  }
}

</script>

<style scoped>


</style>
