namespace blzrlunch.GlobalStores
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using blzrlunch.Client.Pages.components;

    public class StoreList
    {
        public List<Store> targetStores {get; set;} = new List<Store>();

        public event Action onJoinList;

        public void ExecuteStoreInOut(Store store)
        {
            var selectedStore = from s in this.targetStores where s.seq==store.seq select s;

            if(selectedStore.Count() == 0){
                this.targetStores.Add(store);
            }
            else{
                this.targetStores.Remove(selectedStore.ElementAt(0));
            }
        }

    }
}