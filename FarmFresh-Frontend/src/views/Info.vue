<template >
  <div class="main pt-3 pl-5">

    <div class="row sc">
      <div class="col-6 font-weight-bold">
        <div style="font-size: 60px;">
          FRESH FOOD FOR
        </div>
        <div style="font-size: 60px;">
          A FRESHER YOU
        </div>

        <div class="mt-5" style="font-size: 36px;">
          Quality food, Quality life.
        </div>
      </div>
      <div class="col-5 ml-5">
        <img class="img-promo" src="@/assets/sideimage.png" >
      </div>
    </div>

    <div class="row px-5 mt-5 text-center promosc">
      <div class="col-3">
        <img class="img-promo-sm" src="@/assets/1.png" >
        <div style="font-size: 36px;"> Online anywhere </div>
      </div>
      <div class="col-3">
        <img class="img-promo-sm" src="@/assets/2.png" >
        <div style="font-size: 36px;"> Fast Delivery </div>
      </div>
      <div class="col-3">
        <img class="img-promo-sm" src="@/assets/3.png" >
        <div style="font-size: 36px;"> 24/7 Support </div>
      </div>
    </div>

  </div>
</template>

<script>


export default {
  name:'Info',
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
            this.$router.push({ path: 'products' })
          }

          this.scrollPosition = window.scrollY
    }
  }
}


</script>

<style scoped>
  .main{
    font-family: Helvetica Neue;
    background-color: #ffff;
    overflow: hidden;
    height: 90vh;
  }

 .promosc{
  justify-content: space-between;
 }
  
  .img-promo {
    height: 100%;
    width: 100%;
  }

  .img-promo-sm {
    height: 50%;
    width: 50%;
  }
</style>
