<template>
  <div class="container-flex sticky">
    <nav class="navbar">
        <div class="col-2">
          <a class="navbar-brand py-0">
            <img src="@/assets/fi-logo.svg" @click.prevent="clearSearch()">
          </a>
        </div>
        <div class="col-9 pt-4">
          <div class="row">
            <div class="col-5 p-0">
              <input class="p-2 searc" type="text" v-model="inputName" placeholder="Search for a product or brand" />
            </div>
            <div class="col-2 p-0">
              <img class="searcicon p-2" src="@/assets/search.svg" @click.prevent="searchProduct(inputName)">
            </div>
          </div>
        </div>
        <div class="col-1 bag">
          <img class="pb-1" src="@/assets/cart.svg">
        </div>
    </nav>
  </div>
</template>

<script>

export default {
  name: 'Header',
  components: {
    
  },
  data() {
    return {
      inputName: ''
    }
  },
  mounted() {
    this.inputName = this.it
  },
  computed: {
    it(){
      return this.$store.state.searchedName
    }
  },
  methods: {
    searchProduct(name) {
      this.$store.commit('updateSerchedName', name);
      if(name == null || name == '')
      {
        name = 'all';
      }
      window.location.href = `/products/${name}`
    },
    clearSearch(){
      this.inputName = '';
      this.$store.commit('updateSerchedName', '');
      this.$router.push({ path: '/' })
    }
  }
}
</script>

<style>
nav {
  z-index:100;
  height: 17vh;
}
.navbar {
  border-bottom: 2px solid #DCDCDC;
  background-color: #ffffff;
}

.sticky {
  position: -webkit-sticky;
  position: sticky;
  top: 0;
  width: 100%;
}

.searc {
  height: 60%;
  width: 100%;
}

.searcicon {
  height: 60%;
  background-color: #2e75b4;
}

.searcicon:hover{
  opacity: .5;
}

.btn-sm{
  border-radius: 0;
}

.bag span {
    background-color: #6394F8;
    border-radius: 10px;
    color: white;
    position: absolute;
    font-size: 15px;
    line-height: 1;
    padding: 2px 3px 3px 3px;
    text-align: center;
    vertical-align: middle;
    white-space: nowrap;
    margin-left: -9px;
    bottom: 1rem;
}

.bag img {
  cursor: pointer;
  width: 30px;
  height: auto;
}

.navbar-brand{
  width: 100% !important;
}


.navbar-brand img{
  width: 100% !important;
  height: 80px !important;
}

.navbar-brand img:hover{
  opacity: .3;
  background-color: red;
}

</style>
