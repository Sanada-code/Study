new Vue({
  el: "#app",
  data: {
    lists: ["item1", "item2", "item3", "item4"],
    newItem: "",
  },

  methods: {
    AddItem: function (event) {
      if (this.newItem == "") {
        return;
      }
      this.lists.push(this.newItem);
      this.newItem = "";
    },
  },
});
