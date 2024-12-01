
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public int money = 1;                       // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];

        // Ваши сохранения

        public bool _authorized = false;
        public int _birth;

        /*
        1 - родитель
        0 - ученик
        */

        public int _role;

        public int _money = 0;
        public int _stars = 0;
        public int _xp = 0;

        public bool av1 = false;
        public bool av2 = false;
        public bool av3 = false;
        public bool av4 = false;

        public string _uid = "";

        /*
        1,2,3 - id скина
        0 - дефолт
        */

        public int _avatarid = 0;

        // [COMPUTER SCIENCE COURSE]

        public bool c_l1 = false;
        public bool c_l2 = false;
        public bool c_l3 = false;
        public bool c_l4 = false;
        public bool c_l5 = false;

        // stars
        public int c_s_l1 = 0;
        public int c_s_l2 = 0;
        public int c_s_l3 = 0;
        public int c_s_l4 = 0;
        public int c_s_l5 = 0;

        // [PYTHON COURSE]

        public bool p_l1 = false;
        public bool p_l2 = false;
        public bool p_l3 = false;
        public bool p_l4 = false;
        public bool p_l5 = false;

        // stars
        public int p_s_l1 = 0;
        public int p_s_l2 = 0;
        public int p_s_l3 = 0;
        public int p_s_l4 = 0;
        public int p_s_l5 = 0;

        // [CS COURSE]

        public bool cs_l1 = false;
        public bool cs_l2 = false;
        public bool cs_l3 = false;
        public bool cs_l4 = false;
        public bool cs_l5 = false;

        // stars
        public int cs_s_l1 = 0;
        public int cs_s_l2 = 0;
        public int cs_s_l3 = 0;
        public int cs_s_l4 = 0;
        public int cs_s_l5 = 0;

        // [DevOps COURSE]

        public bool d_l1 = false;
        public bool d_l2 = false;
        public bool d_l3 = false;
        public bool d_l4 = false;
        public bool d_l5 = false;

        // stars
        public int d_s_l1 = 0;
        public int d_s_l2 = 0;
        public int d_s_l3 = 0;
        public int d_s_l4 = 0;
        public int d_s_l5 = 0;

        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива

            openLevels[1] = true;
        }
    }
}
