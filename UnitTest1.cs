namespace QA_FEAST_DEMO
{
    [TestClass]
    public class UnitTest1
    {


        Driver dv = new Driver();
        TextBox TBX = new TextBox();
        Button BT = new Button();
        Hyperlink HP = new Hyperlink();
        Dropdown DP= new Dropdown();
        DragandDropdwon DD = new DragandDropdwon();
        //ContextMenu cm = new ContextMenu();
        DoubleClick dc = new DoubleClick();
        Scrolling SL = new Scrolling();
        Webtable wt = new Webtable();
        FileUpload fu = new FileUpload();
        ChatWindow cw = new ChatWindow();
        Loading LD = new Loading();
        [TestMethod]
        public void TestMethod1()
        {
            dv.drivers();
            TBX.TB();
            BT.Buttons();
            //HP.Linkss();
            DP.dropdowns();
            DD.DragandDropdwons();
            //cm.context();
            dc.DC();
            SL.scroll();
            wt.WTables();
           // fu.FILEFUNCTION();
            cw.CWINDOW();
            LD.Load();

        }
    }
}