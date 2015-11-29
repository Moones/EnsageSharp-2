using Ensage;
using Ensage.Common;
using Ensage.Common.Extensions;
using Ensage.Common.Menu;
using System;
using System.Linq;

namespace axiieflex.ensage2.abuse.tranquilBoots
{
    class Program
    {

        private static readonly Menu Menu = new Menu("Abuse Tranquil", "AbuseTranquil", true, "item_tranquil_boots", true);

        private static string Mutex = "TranquilAbuse";

        private static int MutexTick = 200;

        static void Main(string[] args)
        {
            
            // кнопка для срабатывания
            Menu.AddItem(new MenuItem("hotkey", "HotKey").SetValue(new KeyBind('P', KeyBindType.Press)));

            // добавляем меню
            Menu.AddToMainMenu();

            Game.OnUpdate += OnUpdate;

        }

        

        private static void OnUpdate(EventArgs args)
        {
            var IsDropped = false;

            var me = ObjectMgr.LocalHero;

            if(!Game.IsInGame || me == null) return;

            // если кнопка зажата
            if (!Menu.Item("hotkey").GetValue<KeyBind>().Active) return;

            if (!Utils.SleepCheck(Mutex)) return;

            // если находим транквилы - то выкидываем их
            var pItems = me.Inventory.Items.Where(x => (x.Name == "item_tranquil_boots"));
            // если ничего не нашли - выходим
            if (pItems != null)
            {
                foreach (var i in pItems)
                {
                    // выкидываем под ноги
                    try { me.DropItem(i, me.Position); } catch (Exception) { }
                    Utils.Sleep(MutexTick, Mutex);
                    IsDropped = true;
                }
            }

            // если вещь хотя-бы 1 дропнули, то выходим
            if (IsDropped == true) return;


            // теперь ситуация 2, подбираем свои транквилы
            // ищем вещи в радиусе 550 (это БОЛЬШОЙ радиус)
            var dItems = ObjectMgr.GetEntities<PhysicalItem>().Where(x => (x.Distance2D(me.Position) < 550)  && (x.Item.Name.Contains("tranquil"))).ToArray();

            if (dItems.Length > 0)
            {
                Utils.Sleep(MutexTick, Mutex);

                // поднимаем все вещи
                foreach (var i in dItems)
                {
                    try { ObjectMgr.LocalHero.PickUpItem(i, true); } catch (Exception) { }
                    
                }
            }
                
           

        }


    }
}
