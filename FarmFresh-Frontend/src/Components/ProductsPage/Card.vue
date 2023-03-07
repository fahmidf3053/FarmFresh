<template>
  <div class="products">
    <div v-for="item in Products" class="main" :key="item.id">
      <img class="img-item-sm" :src=getImage(item)>
      <div class="pl-3">{{item.name}}</div>
      <div class="pl-3">{{item.type}}</div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['Products'],
  name: 'Card',
  methods: {
    addtoCart(it) {
     this.$store.commit('inCart', it)
    },
    sendInfo(it) {
     this.$store.commit('addtoInfo', it)
    },
    getImage(item){
      return require('@/assets/products/'+item.image)
    }
  }
}
</script>

<style scoped>


.products {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  padding-top: 1%;
  padding-left: 10%;
}

  .main{
    font-family: Helvetica Neue;
    font-size: 21px;
    font-weight: bold;
    justify-content: space-between;
  }

.img-item-sm {
    height: 70%;
    width: 65%;
    background-color: #ffff;
    border-radius: 20%;
  }

</style>
