<template>
  <div class="modal-backdrop">
    <div class="modal">
      <div class="col-5 p-0">
        <button
            type="button"
            class="btn-x"
          @click="close">X</button>
        <img class="img-item" :src=getImage(Product)>
      </div>
      <div class="col-7 ml-5 pt-3" style="position: relative;">
        <div style="font-size: 36px;">{{ Product.name }}</div>
        <div style="font-size: 24px;">{{ Product.type }} of 1 bundle</div>
        <div style="font-size: 12px; padding-top: 5px">
          <div class="row">
            <div class="col-5">Key Information</div><div class="col-6 pr-2">{{ Product.type }} of 1 bundle of {{Product.name}}</div>
          </div>
          <div class="row">
            <div class="col-5">About the Product</div>
            <div v-if="Product.about.length > 70 && isMoreNedded" class="col-6 pr-2">{{ getShortAbout(Product.about) }}<button class="more" @click="toggleAbout">...more</button></div>
            <div v-else class="col-6 pr-2">{{ Product.about }}<button class="more" v-if="Product.about.length > 70" @click="toggleAbout">..less</button></div>
          </div>
          <div class="row">
            <div class="col-5">Country of Origin</div><div class="col-6 pr-2">{{Product.origin}}</div>
          </div>
          <div class="row">
            <div class="col-5">Price</div><div class="col-6 pr-2">{{Product.price}}</div>
          </div>
        </div>

        <div class="row" style="position: absolute; bottom: 0; left: 0; padding: 0px; width: 100%;">
          <div class="col-2 pt-1 qty">
            Qty
          </div>
          <div class="col-3 p-0 ml-2 mr-3">
            <input class="inputqty" type="number" v-model="qty">
          </div>
          <div class="col-6 p-0">
            <button
            type="button"
            class="btn-close"
            @click="close">ADD TO CART</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['Product'],
  name: 'ProductModal',
  data() {
    return {
      qty: 1,
      isMoreNedded: true
    }
  },
  mounted(){

  },
  methods: {
    close() {
      this.$emit('close');
    },
    getImage(item){
      return require('@/assets/products/'+item.image)
    },
    getShortAbout(about){
      var res;

      if(about.length > 70)
      {
        res = about.substring(0,70);
      }
      else
      {
        res = about;
      }

      return res;
    },
    toggleAbout(){
      this.isMoreNedded = !this.isMoreNedded;
    }
  }
}
</script>

<style scoped>

  .modal-backdrop {
    position: fixed;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    background: transparent;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  .modal {
    background: #FFFFFF;
    box-shadow: 2px 2px 20px 1px;
    top: 21%;
    left: 28%;
    display: flex;
    padding: 1% 0% 5% 5%;
    height: 75%;
    width: 70%;
    font-weight: bold;
  }

  .more{
    color: #ce585c;
    border: none;
    background: transparent;
    cursor: pointer;
  }

  .btn-close {
    border: none;
    font-size: 21px;
    padding: 0px 15% 0px 15%;
    cursor: pointer;
    color: #ffffff;
    background-color: #ce585c;
    border-radius: 12px;
  }

  .btn-x {
    border:none;
    font-size: 15px;
    cursor: pointer;
    border-radius: 12px;
    color: #ffffff;
    background-color: #ce585c;
  }

  button:focus{
    outline: 0 !important;
  }

  .img-item {
      height: 100%;
      width: 100%;
  }

  .inputqty{
    width: 80%;
    text-align: center;
    border-radius: 12px;
  }

  .qty{
    width: 100%;
    text-align: center;
    border-radius: 12px;
    color: #ffffff;
    background-color: #ce585c;
  }
</style>
