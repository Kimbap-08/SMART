#nullable disable

namespace SMART
{

public sealed partial class InstructorCalendar
{
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.TableLayoutPanel root;
    private System.Windows.Forms.Panel header;
    private System.Windows.Forms.Label heading;
    private CustomButton previous;
    private CustomButton next;
    private System.Windows.Forms.Label monthLabel;
    private System.Windows.Forms.TableLayoutPanel calendarGrid;
    private System.Windows.Forms.Label weekday0;
    private System.Windows.Forms.Label weekday1;
    private System.Windows.Forms.Label weekday2;
    private System.Windows.Forms.Label weekday3;
    private System.Windows.Forms.Label weekday4;
    private System.Windows.Forms.Label weekday5;
    private System.Windows.Forms.Label weekday6;
    private CustomPanel eventCard;
    private System.Windows.Forms.TableLayoutPanel formRows;
    private System.Windows.Forms.TableLayoutPanel firstRow;
    private System.Windows.Forms.TableLayoutPanel secondRow;
    private RoundedTextBox titleInput;
    private RoundedTextBox descriptionInput;
    private System.Windows.Forms.DateTimePicker eventDate;
    private System.Windows.Forms.ComboBox eventType;
    private System.Windows.Forms.ComboBox coursePicker;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label dateLabel;
    private System.Windows.Forms.Label typeLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.Label courseLabel;
    private System.Windows.Forms.FlowLayoutPanel actions;
    private CustomButton addButton;
    private CustomButton deleteButton;
    private System.Windows.Forms.Label message;
    private System.Windows.Forms.FlowLayoutPanel legend;
    private System.Windows.Forms.FlowLayoutPanel legendItem0;
    private System.Windows.Forms.Panel legendSwatch0;
    private System.Windows.Forms.Label legendLabel0;
    private System.Windows.Forms.FlowLayoutPanel legendItem1;
    private System.Windows.Forms.Panel legendSwatch1;
    private System.Windows.Forms.Label legendLabel1;
    private System.Windows.Forms.FlowLayoutPanel legendItem2;
    private System.Windows.Forms.Panel legendSwatch2;
    private System.Windows.Forms.Label legendLabel2;
    private System.Windows.Forms.FlowLayoutPanel legendItem3;
    private System.Windows.Forms.Panel legendSwatch3;
    private System.Windows.Forms.Label legendLabel3;
    private System.Windows.Forms.FlowLayoutPanel legendItem4;
    private System.Windows.Forms.Panel legendSwatch4;
    private System.Windows.Forms.Label legendLabel4;
    private System.Windows.Forms.FlowLayoutPanel legendItem5;
    private System.Windows.Forms.Panel legendSwatch5;
    private System.Windows.Forms.Label legendLabel5;
    private System.Windows.Forms.FlowLayoutPanel legendItem6;
    private System.Windows.Forms.Panel legendSwatch6;
    private System.Windows.Forms.Label legendLabel6;

    private CustomPanel dayCell00;
    private System.Windows.Forms.Label dayNumber00;
    private System.Windows.Forms.FlowLayoutPanel dayEvents00;
    private CustomButton eventChip00_0;
    private CustomButton eventChip00_1;
    private System.Windows.Forms.Label moreEvents00;
    private CustomPanel dayCell01;
    private System.Windows.Forms.Label dayNumber01;
    private System.Windows.Forms.FlowLayoutPanel dayEvents01;
    private CustomButton eventChip01_0;
    private CustomButton eventChip01_1;
    private System.Windows.Forms.Label moreEvents01;
    private CustomPanel dayCell02;
    private System.Windows.Forms.Label dayNumber02;
    private System.Windows.Forms.FlowLayoutPanel dayEvents02;
    private CustomButton eventChip02_0;
    private CustomButton eventChip02_1;
    private System.Windows.Forms.Label moreEvents02;
    private CustomPanel dayCell03;
    private System.Windows.Forms.Label dayNumber03;
    private System.Windows.Forms.FlowLayoutPanel dayEvents03;
    private CustomButton eventChip03_0;
    private CustomButton eventChip03_1;
    private System.Windows.Forms.Label moreEvents03;
    private CustomPanel dayCell04;
    private System.Windows.Forms.Label dayNumber04;
    private System.Windows.Forms.FlowLayoutPanel dayEvents04;
    private CustomButton eventChip04_0;
    private CustomButton eventChip04_1;
    private System.Windows.Forms.Label moreEvents04;
    private CustomPanel dayCell05;
    private System.Windows.Forms.Label dayNumber05;
    private System.Windows.Forms.FlowLayoutPanel dayEvents05;
    private CustomButton eventChip05_0;
    private CustomButton eventChip05_1;
    private System.Windows.Forms.Label moreEvents05;
    private CustomPanel dayCell06;
    private System.Windows.Forms.Label dayNumber06;
    private System.Windows.Forms.FlowLayoutPanel dayEvents06;
    private CustomButton eventChip06_0;
    private CustomButton eventChip06_1;
    private System.Windows.Forms.Label moreEvents06;
    private CustomPanel dayCell07;
    private System.Windows.Forms.Label dayNumber07;
    private System.Windows.Forms.FlowLayoutPanel dayEvents07;
    private CustomButton eventChip07_0;
    private CustomButton eventChip07_1;
    private System.Windows.Forms.Label moreEvents07;
    private CustomPanel dayCell08;
    private System.Windows.Forms.Label dayNumber08;
    private System.Windows.Forms.FlowLayoutPanel dayEvents08;
    private CustomButton eventChip08_0;
    private CustomButton eventChip08_1;
    private System.Windows.Forms.Label moreEvents08;
    private CustomPanel dayCell09;
    private System.Windows.Forms.Label dayNumber09;
    private System.Windows.Forms.FlowLayoutPanel dayEvents09;
    private CustomButton eventChip09_0;
    private CustomButton eventChip09_1;
    private System.Windows.Forms.Label moreEvents09;
    private CustomPanel dayCell10;
    private System.Windows.Forms.Label dayNumber10;
    private System.Windows.Forms.FlowLayoutPanel dayEvents10;
    private CustomButton eventChip10_0;
    private CustomButton eventChip10_1;
    private System.Windows.Forms.Label moreEvents10;
    private CustomPanel dayCell11;
    private System.Windows.Forms.Label dayNumber11;
    private System.Windows.Forms.FlowLayoutPanel dayEvents11;
    private CustomButton eventChip11_0;
    private CustomButton eventChip11_1;
    private System.Windows.Forms.Label moreEvents11;
    private CustomPanel dayCell12;
    private System.Windows.Forms.Label dayNumber12;
    private System.Windows.Forms.FlowLayoutPanel dayEvents12;
    private CustomButton eventChip12_0;
    private CustomButton eventChip12_1;
    private System.Windows.Forms.Label moreEvents12;
    private CustomPanel dayCell13;
    private System.Windows.Forms.Label dayNumber13;
    private System.Windows.Forms.FlowLayoutPanel dayEvents13;
    private CustomButton eventChip13_0;
    private CustomButton eventChip13_1;
    private System.Windows.Forms.Label moreEvents13;
    private CustomPanel dayCell14;
    private System.Windows.Forms.Label dayNumber14;
    private System.Windows.Forms.FlowLayoutPanel dayEvents14;
    private CustomButton eventChip14_0;
    private CustomButton eventChip14_1;
    private System.Windows.Forms.Label moreEvents14;
    private CustomPanel dayCell15;
    private System.Windows.Forms.Label dayNumber15;
    private System.Windows.Forms.FlowLayoutPanel dayEvents15;
    private CustomButton eventChip15_0;
    private CustomButton eventChip15_1;
    private System.Windows.Forms.Label moreEvents15;
    private CustomPanel dayCell16;
    private System.Windows.Forms.Label dayNumber16;
    private System.Windows.Forms.FlowLayoutPanel dayEvents16;
    private CustomButton eventChip16_0;
    private CustomButton eventChip16_1;
    private System.Windows.Forms.Label moreEvents16;
    private CustomPanel dayCell17;
    private System.Windows.Forms.Label dayNumber17;
    private System.Windows.Forms.FlowLayoutPanel dayEvents17;
    private CustomButton eventChip17_0;
    private CustomButton eventChip17_1;
    private System.Windows.Forms.Label moreEvents17;
    private CustomPanel dayCell18;
    private System.Windows.Forms.Label dayNumber18;
    private System.Windows.Forms.FlowLayoutPanel dayEvents18;
    private CustomButton eventChip18_0;
    private CustomButton eventChip18_1;
    private System.Windows.Forms.Label moreEvents18;
    private CustomPanel dayCell19;
    private System.Windows.Forms.Label dayNumber19;
    private System.Windows.Forms.FlowLayoutPanel dayEvents19;
    private CustomButton eventChip19_0;
    private CustomButton eventChip19_1;
    private System.Windows.Forms.Label moreEvents19;
    private CustomPanel dayCell20;
    private System.Windows.Forms.Label dayNumber20;
    private System.Windows.Forms.FlowLayoutPanel dayEvents20;
    private CustomButton eventChip20_0;
    private CustomButton eventChip20_1;
    private System.Windows.Forms.Label moreEvents20;
    private CustomPanel dayCell21;
    private System.Windows.Forms.Label dayNumber21;
    private System.Windows.Forms.FlowLayoutPanel dayEvents21;
    private CustomButton eventChip21_0;
    private CustomButton eventChip21_1;
    private System.Windows.Forms.Label moreEvents21;
    private CustomPanel dayCell22;
    private System.Windows.Forms.Label dayNumber22;
    private System.Windows.Forms.FlowLayoutPanel dayEvents22;
    private CustomButton eventChip22_0;
    private CustomButton eventChip22_1;
    private System.Windows.Forms.Label moreEvents22;
    private CustomPanel dayCell23;
    private System.Windows.Forms.Label dayNumber23;
    private System.Windows.Forms.FlowLayoutPanel dayEvents23;
    private CustomButton eventChip23_0;
    private CustomButton eventChip23_1;
    private System.Windows.Forms.Label moreEvents23;
    private CustomPanel dayCell24;
    private System.Windows.Forms.Label dayNumber24;
    private System.Windows.Forms.FlowLayoutPanel dayEvents24;
    private CustomButton eventChip24_0;
    private CustomButton eventChip24_1;
    private System.Windows.Forms.Label moreEvents24;
    private CustomPanel dayCell25;
    private System.Windows.Forms.Label dayNumber25;
    private System.Windows.Forms.FlowLayoutPanel dayEvents25;
    private CustomButton eventChip25_0;
    private CustomButton eventChip25_1;
    private System.Windows.Forms.Label moreEvents25;
    private CustomPanel dayCell26;
    private System.Windows.Forms.Label dayNumber26;
    private System.Windows.Forms.FlowLayoutPanel dayEvents26;
    private CustomButton eventChip26_0;
    private CustomButton eventChip26_1;
    private System.Windows.Forms.Label moreEvents26;
    private CustomPanel dayCell27;
    private System.Windows.Forms.Label dayNumber27;
    private System.Windows.Forms.FlowLayoutPanel dayEvents27;
    private CustomButton eventChip27_0;
    private CustomButton eventChip27_1;
    private System.Windows.Forms.Label moreEvents27;
    private CustomPanel dayCell28;
    private System.Windows.Forms.Label dayNumber28;
    private System.Windows.Forms.FlowLayoutPanel dayEvents28;
    private CustomButton eventChip28_0;
    private CustomButton eventChip28_1;
    private System.Windows.Forms.Label moreEvents28;
    private CustomPanel dayCell29;
    private System.Windows.Forms.Label dayNumber29;
    private System.Windows.Forms.FlowLayoutPanel dayEvents29;
    private CustomButton eventChip29_0;
    private CustomButton eventChip29_1;
    private System.Windows.Forms.Label moreEvents29;
    private CustomPanel dayCell30;
    private System.Windows.Forms.Label dayNumber30;
    private System.Windows.Forms.FlowLayoutPanel dayEvents30;
    private CustomButton eventChip30_0;
    private CustomButton eventChip30_1;
    private System.Windows.Forms.Label moreEvents30;
    private CustomPanel dayCell31;
    private System.Windows.Forms.Label dayNumber31;
    private System.Windows.Forms.FlowLayoutPanel dayEvents31;
    private CustomButton eventChip31_0;
    private CustomButton eventChip31_1;
    private System.Windows.Forms.Label moreEvents31;
    private CustomPanel dayCell32;
    private System.Windows.Forms.Label dayNumber32;
    private System.Windows.Forms.FlowLayoutPanel dayEvents32;
    private CustomButton eventChip32_0;
    private CustomButton eventChip32_1;
    private System.Windows.Forms.Label moreEvents32;
    private CustomPanel dayCell33;
    private System.Windows.Forms.Label dayNumber33;
    private System.Windows.Forms.FlowLayoutPanel dayEvents33;
    private CustomButton eventChip33_0;
    private CustomButton eventChip33_1;
    private System.Windows.Forms.Label moreEvents33;
    private CustomPanel dayCell34;
    private System.Windows.Forms.Label dayNumber34;
    private System.Windows.Forms.FlowLayoutPanel dayEvents34;
    private CustomButton eventChip34_0;
    private CustomButton eventChip34_1;
    private System.Windows.Forms.Label moreEvents34;
    private CustomPanel dayCell35;
    private System.Windows.Forms.Label dayNumber35;
    private System.Windows.Forms.FlowLayoutPanel dayEvents35;
    private CustomButton eventChip35_0;
    private CustomButton eventChip35_1;
    private System.Windows.Forms.Label moreEvents35;
    private CustomPanel dayCell36;
    private System.Windows.Forms.Label dayNumber36;
    private System.Windows.Forms.FlowLayoutPanel dayEvents36;
    private CustomButton eventChip36_0;
    private CustomButton eventChip36_1;
    private System.Windows.Forms.Label moreEvents36;
    private CustomPanel dayCell37;
    private System.Windows.Forms.Label dayNumber37;
    private System.Windows.Forms.FlowLayoutPanel dayEvents37;
    private CustomButton eventChip37_0;
    private CustomButton eventChip37_1;
    private System.Windows.Forms.Label moreEvents37;
    private CustomPanel dayCell38;
    private System.Windows.Forms.Label dayNumber38;
    private System.Windows.Forms.FlowLayoutPanel dayEvents38;
    private CustomButton eventChip38_0;
    private CustomButton eventChip38_1;
    private System.Windows.Forms.Label moreEvents38;
    private CustomPanel dayCell39;
    private System.Windows.Forms.Label dayNumber39;
    private System.Windows.Forms.FlowLayoutPanel dayEvents39;
    private CustomButton eventChip39_0;
    private CustomButton eventChip39_1;
    private System.Windows.Forms.Label moreEvents39;
    private CustomPanel dayCell40;
    private System.Windows.Forms.Label dayNumber40;
    private System.Windows.Forms.FlowLayoutPanel dayEvents40;
    private CustomButton eventChip40_0;
    private CustomButton eventChip40_1;
    private System.Windows.Forms.Label moreEvents40;
    private CustomPanel dayCell41;
    private System.Windows.Forms.Label dayNumber41;
    private System.Windows.Forms.FlowLayoutPanel dayEvents41;
    private CustomButton eventChip41_0;
    private CustomButton eventChip41_1;
    private System.Windows.Forms.Label moreEvents41;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            root = new TableLayoutPanel();
            header = new Panel();
            previous = new CustomButton();
            next = new CustomButton();
            monthLabel = new Label();
            heading = new Label();
            calendarGrid = new TableLayoutPanel();
            weekday0 = new Label();
            weekday1 = new Label();
            weekday2 = new Label();
            weekday3 = new Label();
            weekday4 = new Label();
            weekday5 = new Label();
            weekday6 = new Label();
            dayCell00 = new CustomPanel();
            dayEvents00 = new FlowLayoutPanel();
            eventChip00_0 = new CustomButton();
            eventChip00_1 = new CustomButton();
            moreEvents00 = new Label();
            dayNumber00 = new Label();
            dayCell01 = new CustomPanel();
            dayEvents01 = new FlowLayoutPanel();
            eventChip01_0 = new CustomButton();
            eventChip01_1 = new CustomButton();
            moreEvents01 = new Label();
            dayNumber01 = new Label();
            dayCell02 = new CustomPanel();
            dayEvents02 = new FlowLayoutPanel();
            eventChip02_0 = new CustomButton();
            eventChip02_1 = new CustomButton();
            moreEvents02 = new Label();
            dayNumber02 = new Label();
            dayCell03 = new CustomPanel();
            dayEvents03 = new FlowLayoutPanel();
            eventChip03_0 = new CustomButton();
            eventChip03_1 = new CustomButton();
            moreEvents03 = new Label();
            dayNumber03 = new Label();
            dayCell04 = new CustomPanel();
            dayEvents04 = new FlowLayoutPanel();
            eventChip04_0 = new CustomButton();
            eventChip04_1 = new CustomButton();
            moreEvents04 = new Label();
            dayNumber04 = new Label();
            dayCell05 = new CustomPanel();
            dayEvents05 = new FlowLayoutPanel();
            eventChip05_0 = new CustomButton();
            eventChip05_1 = new CustomButton();
            moreEvents05 = new Label();
            dayNumber05 = new Label();
            dayCell06 = new CustomPanel();
            dayEvents06 = new FlowLayoutPanel();
            eventChip06_0 = new CustomButton();
            eventChip06_1 = new CustomButton();
            moreEvents06 = new Label();
            dayNumber06 = new Label();
            dayCell07 = new CustomPanel();
            dayEvents07 = new FlowLayoutPanel();
            eventChip07_0 = new CustomButton();
            eventChip07_1 = new CustomButton();
            moreEvents07 = new Label();
            dayNumber07 = new Label();
            dayCell08 = new CustomPanel();
            dayEvents08 = new FlowLayoutPanel();
            eventChip08_0 = new CustomButton();
            eventChip08_1 = new CustomButton();
            moreEvents08 = new Label();
            dayNumber08 = new Label();
            dayCell09 = new CustomPanel();
            dayEvents09 = new FlowLayoutPanel();
            eventChip09_0 = new CustomButton();
            eventChip09_1 = new CustomButton();
            moreEvents09 = new Label();
            dayNumber09 = new Label();
            dayCell10 = new CustomPanel();
            dayEvents10 = new FlowLayoutPanel();
            eventChip10_0 = new CustomButton();
            eventChip10_1 = new CustomButton();
            moreEvents10 = new Label();
            dayNumber10 = new Label();
            dayCell11 = new CustomPanel();
            dayEvents11 = new FlowLayoutPanel();
            eventChip11_0 = new CustomButton();
            eventChip11_1 = new CustomButton();
            moreEvents11 = new Label();
            dayNumber11 = new Label();
            dayCell12 = new CustomPanel();
            dayEvents12 = new FlowLayoutPanel();
            eventChip12_0 = new CustomButton();
            eventChip12_1 = new CustomButton();
            moreEvents12 = new Label();
            dayNumber12 = new Label();
            dayCell13 = new CustomPanel();
            dayEvents13 = new FlowLayoutPanel();
            eventChip13_0 = new CustomButton();
            eventChip13_1 = new CustomButton();
            moreEvents13 = new Label();
            dayNumber13 = new Label();
            dayCell14 = new CustomPanel();
            dayEvents14 = new FlowLayoutPanel();
            eventChip14_0 = new CustomButton();
            eventChip14_1 = new CustomButton();
            moreEvents14 = new Label();
            dayNumber14 = new Label();
            dayCell15 = new CustomPanel();
            dayEvents15 = new FlowLayoutPanel();
            eventChip15_0 = new CustomButton();
            eventChip15_1 = new CustomButton();
            moreEvents15 = new Label();
            dayNumber15 = new Label();
            dayCell16 = new CustomPanel();
            dayEvents16 = new FlowLayoutPanel();
            eventChip16_0 = new CustomButton();
            eventChip16_1 = new CustomButton();
            moreEvents16 = new Label();
            dayNumber16 = new Label();
            dayCell17 = new CustomPanel();
            dayEvents17 = new FlowLayoutPanel();
            eventChip17_0 = new CustomButton();
            eventChip17_1 = new CustomButton();
            moreEvents17 = new Label();
            dayNumber17 = new Label();
            dayCell18 = new CustomPanel();
            dayEvents18 = new FlowLayoutPanel();
            eventChip18_0 = new CustomButton();
            eventChip18_1 = new CustomButton();
            moreEvents18 = new Label();
            dayNumber18 = new Label();
            dayCell19 = new CustomPanel();
            dayEvents19 = new FlowLayoutPanel();
            eventChip19_0 = new CustomButton();
            eventChip19_1 = new CustomButton();
            moreEvents19 = new Label();
            dayNumber19 = new Label();
            dayCell20 = new CustomPanel();
            dayEvents20 = new FlowLayoutPanel();
            eventChip20_0 = new CustomButton();
            eventChip20_1 = new CustomButton();
            moreEvents20 = new Label();
            dayNumber20 = new Label();
            dayCell21 = new CustomPanel();
            dayEvents21 = new FlowLayoutPanel();
            eventChip21_0 = new CustomButton();
            eventChip21_1 = new CustomButton();
            moreEvents21 = new Label();
            dayNumber21 = new Label();
            dayCell22 = new CustomPanel();
            dayEvents22 = new FlowLayoutPanel();
            eventChip22_0 = new CustomButton();
            eventChip22_1 = new CustomButton();
            moreEvents22 = new Label();
            dayNumber22 = new Label();
            dayCell23 = new CustomPanel();
            dayEvents23 = new FlowLayoutPanel();
            eventChip23_0 = new CustomButton();
            eventChip23_1 = new CustomButton();
            moreEvents23 = new Label();
            dayNumber23 = new Label();
            dayCell24 = new CustomPanel();
            dayEvents24 = new FlowLayoutPanel();
            eventChip24_0 = new CustomButton();
            eventChip24_1 = new CustomButton();
            moreEvents24 = new Label();
            dayNumber24 = new Label();
            dayCell25 = new CustomPanel();
            dayEvents25 = new FlowLayoutPanel();
            eventChip25_0 = new CustomButton();
            eventChip25_1 = new CustomButton();
            moreEvents25 = new Label();
            dayNumber25 = new Label();
            dayCell26 = new CustomPanel();
            dayEvents26 = new FlowLayoutPanel();
            eventChip26_0 = new CustomButton();
            eventChip26_1 = new CustomButton();
            moreEvents26 = new Label();
            dayNumber26 = new Label();
            dayCell27 = new CustomPanel();
            dayEvents27 = new FlowLayoutPanel();
            eventChip27_0 = new CustomButton();
            eventChip27_1 = new CustomButton();
            moreEvents27 = new Label();
            dayNumber27 = new Label();
            dayCell28 = new CustomPanel();
            dayEvents28 = new FlowLayoutPanel();
            eventChip28_0 = new CustomButton();
            eventChip28_1 = new CustomButton();
            moreEvents28 = new Label();
            dayNumber28 = new Label();
            dayCell29 = new CustomPanel();
            dayEvents29 = new FlowLayoutPanel();
            eventChip29_0 = new CustomButton();
            eventChip29_1 = new CustomButton();
            moreEvents29 = new Label();
            dayNumber29 = new Label();
            dayCell30 = new CustomPanel();
            dayEvents30 = new FlowLayoutPanel();
            eventChip30_0 = new CustomButton();
            eventChip30_1 = new CustomButton();
            moreEvents30 = new Label();
            dayNumber30 = new Label();
            dayCell31 = new CustomPanel();
            dayEvents31 = new FlowLayoutPanel();
            eventChip31_0 = new CustomButton();
            eventChip31_1 = new CustomButton();
            moreEvents31 = new Label();
            dayNumber31 = new Label();
            dayCell32 = new CustomPanel();
            dayEvents32 = new FlowLayoutPanel();
            eventChip32_0 = new CustomButton();
            eventChip32_1 = new CustomButton();
            moreEvents32 = new Label();
            dayNumber32 = new Label();
            dayCell33 = new CustomPanel();
            dayEvents33 = new FlowLayoutPanel();
            eventChip33_0 = new CustomButton();
            eventChip33_1 = new CustomButton();
            moreEvents33 = new Label();
            dayNumber33 = new Label();
            dayCell34 = new CustomPanel();
            dayEvents34 = new FlowLayoutPanel();
            eventChip34_0 = new CustomButton();
            eventChip34_1 = new CustomButton();
            moreEvents34 = new Label();
            dayNumber34 = new Label();
            dayCell35 = new CustomPanel();
            dayEvents35 = new FlowLayoutPanel();
            eventChip35_0 = new CustomButton();
            eventChip35_1 = new CustomButton();
            moreEvents35 = new Label();
            dayNumber35 = new Label();
            dayCell36 = new CustomPanel();
            dayEvents36 = new FlowLayoutPanel();
            eventChip36_0 = new CustomButton();
            eventChip36_1 = new CustomButton();
            moreEvents36 = new Label();
            dayNumber36 = new Label();
            dayCell37 = new CustomPanel();
            dayEvents37 = new FlowLayoutPanel();
            eventChip37_0 = new CustomButton();
            eventChip37_1 = new CustomButton();
            moreEvents37 = new Label();
            dayNumber37 = new Label();
            dayCell38 = new CustomPanel();
            dayEvents38 = new FlowLayoutPanel();
            eventChip38_0 = new CustomButton();
            eventChip38_1 = new CustomButton();
            moreEvents38 = new Label();
            dayNumber38 = new Label();
            dayCell39 = new CustomPanel();
            dayEvents39 = new FlowLayoutPanel();
            eventChip39_0 = new CustomButton();
            eventChip39_1 = new CustomButton();
            moreEvents39 = new Label();
            dayNumber39 = new Label();
            dayCell40 = new CustomPanel();
            dayEvents40 = new FlowLayoutPanel();
            eventChip40_0 = new CustomButton();
            eventChip40_1 = new CustomButton();
            moreEvents40 = new Label();
            dayNumber40 = new Label();
            dayCell41 = new CustomPanel();
            dayEvents41 = new FlowLayoutPanel();
            eventChip41_0 = new CustomButton();
            eventChip41_1 = new CustomButton();
            moreEvents41 = new Label();
            dayNumber41 = new Label();
            eventCard = new CustomPanel();
            formRows = new TableLayoutPanel();
            firstRow = new TableLayoutPanel();
            titleLabel = new Label();
            titleInput = new RoundedTextBox();
            dateLabel = new Label();
            eventDate = new DateTimePicker();
            typeLabel = new Label();
            eventType = new ComboBox();
            secondRow = new TableLayoutPanel();
            descriptionLabel = new Label();
            descriptionInput = new RoundedTextBox();
            courseLabel = new Label();
            coursePicker = new ComboBox();
            actions = new FlowLayoutPanel();
            addButton = new CustomButton();
            deleteButton = new CustomButton();
            message = new Label();
            legend = new FlowLayoutPanel();
            legendItem0 = new FlowLayoutPanel();
            legendSwatch0 = new Panel();
            legendLabel0 = new Label();
            legendItem1 = new FlowLayoutPanel();
            legendSwatch1 = new Panel();
            legendLabel1 = new Label();
            legendItem2 = new FlowLayoutPanel();
            legendSwatch2 = new Panel();
            legendLabel2 = new Label();
            legendItem3 = new FlowLayoutPanel();
            legendSwatch3 = new Panel();
            legendLabel3 = new Label();
            legendItem4 = new FlowLayoutPanel();
            legendSwatch4 = new Panel();
            legendLabel4 = new Label();
            legendItem5 = new FlowLayoutPanel();
            legendSwatch5 = new Panel();
            legendLabel5 = new Label();
            legendItem6 = new FlowLayoutPanel();
            legendSwatch6 = new Panel();
            legendLabel6 = new Label();
            root.SuspendLayout();
            header.SuspendLayout();
            calendarGrid.SuspendLayout();
            dayCell00.SuspendLayout();
            dayEvents00.SuspendLayout();
            dayCell01.SuspendLayout();
            dayEvents01.SuspendLayout();
            dayCell02.SuspendLayout();
            dayEvents02.SuspendLayout();
            dayCell03.SuspendLayout();
            dayEvents03.SuspendLayout();
            dayCell04.SuspendLayout();
            dayEvents04.SuspendLayout();
            dayCell05.SuspendLayout();
            dayEvents05.SuspendLayout();
            dayCell06.SuspendLayout();
            dayEvents06.SuspendLayout();
            dayCell07.SuspendLayout();
            dayEvents07.SuspendLayout();
            dayCell08.SuspendLayout();
            dayEvents08.SuspendLayout();
            dayCell09.SuspendLayout();
            dayEvents09.SuspendLayout();
            dayCell10.SuspendLayout();
            dayEvents10.SuspendLayout();
            dayCell11.SuspendLayout();
            dayEvents11.SuspendLayout();
            dayCell12.SuspendLayout();
            dayEvents12.SuspendLayout();
            dayCell13.SuspendLayout();
            dayEvents13.SuspendLayout();
            dayCell14.SuspendLayout();
            dayEvents14.SuspendLayout();
            dayCell15.SuspendLayout();
            dayEvents15.SuspendLayout();
            dayCell16.SuspendLayout();
            dayEvents16.SuspendLayout();
            dayCell17.SuspendLayout();
            dayEvents17.SuspendLayout();
            dayCell18.SuspendLayout();
            dayEvents18.SuspendLayout();
            dayCell19.SuspendLayout();
            dayEvents19.SuspendLayout();
            dayCell20.SuspendLayout();
            dayEvents20.SuspendLayout();
            dayCell21.SuspendLayout();
            dayEvents21.SuspendLayout();
            dayCell22.SuspendLayout();
            dayEvents22.SuspendLayout();
            dayCell23.SuspendLayout();
            dayEvents23.SuspendLayout();
            dayCell24.SuspendLayout();
            dayEvents24.SuspendLayout();
            dayCell25.SuspendLayout();
            dayEvents25.SuspendLayout();
            dayCell26.SuspendLayout();
            dayEvents26.SuspendLayout();
            dayCell27.SuspendLayout();
            dayEvents27.SuspendLayout();
            dayCell28.SuspendLayout();
            dayEvents28.SuspendLayout();
            dayCell29.SuspendLayout();
            dayEvents29.SuspendLayout();
            dayCell30.SuspendLayout();
            dayEvents30.SuspendLayout();
            dayCell31.SuspendLayout();
            dayEvents31.SuspendLayout();
            dayCell32.SuspendLayout();
            dayEvents32.SuspendLayout();
            dayCell33.SuspendLayout();
            dayEvents33.SuspendLayout();
            dayCell34.SuspendLayout();
            dayEvents34.SuspendLayout();
            dayCell35.SuspendLayout();
            dayEvents35.SuspendLayout();
            dayCell36.SuspendLayout();
            dayEvents36.SuspendLayout();
            dayCell37.SuspendLayout();
            dayEvents37.SuspendLayout();
            dayCell38.SuspendLayout();
            dayEvents38.SuspendLayout();
            dayCell39.SuspendLayout();
            dayEvents39.SuspendLayout();
            dayCell40.SuspendLayout();
            dayEvents40.SuspendLayout();
            dayCell41.SuspendLayout();
            dayEvents41.SuspendLayout();
            eventCard.SuspendLayout();
            formRows.SuspendLayout();
            firstRow.SuspendLayout();
            secondRow.SuspendLayout();
            actions.SuspendLayout();
            legend.SuspendLayout();
            legendItem0.SuspendLayout();
            legendItem1.SuspendLayout();
            legendItem2.SuspendLayout();
            legendItem3.SuspendLayout();
            legendItem4.SuspendLayout();
            legendItem5.SuspendLayout();
            legendItem6.SuspendLayout();
            SuspendLayout();
            // 
            // root
            // 
            root.BackColor = Color.FromArgb(13, 17, 38);
            root.ColumnCount = 1;
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            root.Controls.Add(header, 0, 0);
            root.Controls.Add(calendarGrid, 0, 1);
            root.Controls.Add(eventCard, 0, 2);
            root.Controls.Add(legend, 0, 3);
            root.Dock = DockStyle.Fill;
            root.Location = new Point(0, 0);
            root.Name = "root";
            root.Padding = new Padding(4);
            root.RowCount = 4;
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            root.Size = new Size(1200, 900);
            root.TabIndex = 0;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(13, 17, 38);
            header.Controls.Add(previous);
            header.Controls.Add(next);
            header.Controls.Add(monthLabel);
            header.Controls.Add(heading);
            header.Dock = DockStyle.Fill;
            header.Location = new Point(7, 7);
            header.Name = "header";
            header.Size = new Size(1186, 38);
            header.TabIndex = 0;
            // 
            // previous
            // 
            previous.BackColor = Color.FromArgb(22, 33, 62);
            previous.BorderColor = Color.White;
            previous.BorderRadius = 6;
            previous.Cursor = Cursors.Hand;
            previous.Dock = DockStyle.Right;
            previous.FlatStyle = FlatStyle.Flat;
            previous.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            previous.ForeColor = Color.White;
            previous.HoverColor = Color.Empty;
            previous.Location = new Point(847, 0);
            previous.Name = "previous";
            previous.PressedColor = Color.Empty;
            previous.Size = new Size(82, 38);
            previous.TabIndex = 0;
            previous.Text = "← Prev";
            previous.UseVisualStyleBackColor = false;
            previous.Click += Previous_Click;
            // 
            // next
            // 
            next.BackColor = Color.FromArgb(22, 33, 62);
            next.BorderColor = Color.White;
            next.BorderRadius = 6;
            next.Cursor = Cursors.Hand;
            next.Dock = DockStyle.Right;
            next.FlatStyle = FlatStyle.Flat;
            next.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            next.ForeColor = Color.White;
            next.HoverColor = Color.Empty;
            next.Location = new Point(929, 0);
            next.Name = "next";
            next.PressedColor = Color.Empty;
            next.Size = new Size(82, 38);
            next.TabIndex = 1;
            next.Text = "Next →";
            next.UseVisualStyleBackColor = false;
            next.Click += Next_Click;
            // 
            // monthLabel
            // 
            monthLabel.Dock = DockStyle.Right;
            monthLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            monthLabel.ForeColor = Color.White;
            monthLabel.Location = new Point(1011, 0);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(175, 38);
            monthLabel.TabIndex = 2;
            monthLabel.Text = "October 2026";
            monthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heading
            // 
            heading.Dock = DockStyle.Left;
            heading.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            heading.ForeColor = Color.White;
            heading.Location = new Point(0, 0);
            heading.Name = "heading";
            heading.Size = new Size(220, 38);
            heading.TabIndex = 3;
            heading.Text = "📅 Calendar";
            heading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // calendarGrid
            // 
            calendarGrid.BackColor = Color.FromArgb(13, 17, 38);
            calendarGrid.ColumnCount = 7;
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarGrid.Controls.Add(weekday0, 0, 0);
            calendarGrid.Controls.Add(weekday1, 1, 0);
            calendarGrid.Controls.Add(weekday2, 2, 0);
            calendarGrid.Controls.Add(weekday3, 3, 0);
            calendarGrid.Controls.Add(weekday4, 4, 0);
            calendarGrid.Controls.Add(weekday5, 5, 0);
            calendarGrid.Controls.Add(weekday6, 6, 0);
            calendarGrid.Controls.Add(dayCell00, 0, 1);
            calendarGrid.Controls.Add(dayCell01, 1, 1);
            calendarGrid.Controls.Add(dayCell02, 2, 1);
            calendarGrid.Controls.Add(dayCell03, 3, 1);
            calendarGrid.Controls.Add(dayCell04, 4, 1);
            calendarGrid.Controls.Add(dayCell05, 5, 1);
            calendarGrid.Controls.Add(dayCell06, 6, 1);
            calendarGrid.Controls.Add(dayCell07, 0, 2);
            calendarGrid.Controls.Add(dayCell08, 1, 2);
            calendarGrid.Controls.Add(dayCell09, 2, 2);
            calendarGrid.Controls.Add(dayCell10, 3, 2);
            calendarGrid.Controls.Add(dayCell11, 4, 2);
            calendarGrid.Controls.Add(dayCell12, 5, 2);
            calendarGrid.Controls.Add(dayCell13, 6, 2);
            calendarGrid.Controls.Add(dayCell14, 0, 3);
            calendarGrid.Controls.Add(dayCell15, 1, 3);
            calendarGrid.Controls.Add(dayCell16, 2, 3);
            calendarGrid.Controls.Add(dayCell17, 3, 3);
            calendarGrid.Controls.Add(dayCell18, 4, 3);
            calendarGrid.Controls.Add(dayCell19, 5, 3);
            calendarGrid.Controls.Add(dayCell20, 6, 3);
            calendarGrid.Controls.Add(dayCell21, 0, 4);
            calendarGrid.Controls.Add(dayCell22, 1, 4);
            calendarGrid.Controls.Add(dayCell23, 2, 4);
            calendarGrid.Controls.Add(dayCell24, 3, 4);
            calendarGrid.Controls.Add(dayCell25, 4, 4);
            calendarGrid.Controls.Add(dayCell26, 5, 4);
            calendarGrid.Controls.Add(dayCell27, 6, 4);
            calendarGrid.Controls.Add(dayCell28, 0, 5);
            calendarGrid.Controls.Add(dayCell29, 1, 5);
            calendarGrid.Controls.Add(dayCell30, 2, 5);
            calendarGrid.Controls.Add(dayCell31, 3, 5);
            calendarGrid.Controls.Add(dayCell32, 4, 5);
            calendarGrid.Controls.Add(dayCell33, 5, 5);
            calendarGrid.Controls.Add(dayCell34, 6, 5);
            calendarGrid.Controls.Add(dayCell35, 0, 6);
            calendarGrid.Controls.Add(dayCell36, 1, 6);
            calendarGrid.Controls.Add(dayCell37, 2, 6);
            calendarGrid.Controls.Add(dayCell38, 3, 6);
            calendarGrid.Controls.Add(dayCell39, 4, 6);
            calendarGrid.Controls.Add(dayCell40, 5, 6);
            calendarGrid.Controls.Add(dayCell41, 6, 6);
            calendarGrid.Dock = DockStyle.Fill;
            calendarGrid.Location = new Point(4, 48);
            calendarGrid.Margin = new Padding(0);
            calendarGrid.Name = "calendarGrid";
            calendarGrid.RowCount = 7;
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            calendarGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            calendarGrid.Size = new Size(1192, 527);
            calendarGrid.TabIndex = 1;
            // 
            // weekday0
            // 
            weekday0.BackColor = Color.FromArgb(22, 33, 62);
            weekday0.Dock = DockStyle.Fill;
            weekday0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday0.ForeColor = Color.FromArgb(150, 150, 170);
            weekday0.Location = new Point(1, 1);
            weekday0.Margin = new Padding(1);
            weekday0.Name = "weekday0";
            weekday0.Size = new Size(168, 23);
            weekday0.TabIndex = 0;
            weekday0.Text = "Sun";
            weekday0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekday1
            // 
            weekday1.BackColor = Color.FromArgb(22, 33, 62);
            weekday1.Dock = DockStyle.Fill;
            weekday1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday1.ForeColor = Color.FromArgb(150, 150, 170);
            weekday1.Location = new Point(171, 1);
            weekday1.Margin = new Padding(1);
            weekday1.Name = "weekday1";
            weekday1.Size = new Size(168, 23);
            weekday1.TabIndex = 1;
            weekday1.Text = "Mon";
            weekday1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekday2
            // 
            weekday2.BackColor = Color.FromArgb(22, 33, 62);
            weekday2.Dock = DockStyle.Fill;
            weekday2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday2.ForeColor = Color.FromArgb(150, 150, 170);
            weekday2.Location = new Point(341, 1);
            weekday2.Margin = new Padding(1);
            weekday2.Name = "weekday2";
            weekday2.Size = new Size(168, 23);
            weekday2.TabIndex = 2;
            weekday2.Text = "Tue";
            weekday2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekday3
            // 
            weekday3.BackColor = Color.FromArgb(22, 33, 62);
            weekday3.Dock = DockStyle.Fill;
            weekday3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday3.ForeColor = Color.FromArgb(150, 150, 170);
            weekday3.Location = new Point(511, 1);
            weekday3.Margin = new Padding(1);
            weekday3.Name = "weekday3";
            weekday3.Size = new Size(168, 23);
            weekday3.TabIndex = 3;
            weekday3.Text = "Wed";
            weekday3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekday4
            // 
            weekday4.BackColor = Color.FromArgb(22, 33, 62);
            weekday4.Dock = DockStyle.Fill;
            weekday4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday4.ForeColor = Color.FromArgb(150, 150, 170);
            weekday4.Location = new Point(681, 1);
            weekday4.Margin = new Padding(1);
            weekday4.Name = "weekday4";
            weekday4.Size = new Size(168, 23);
            weekday4.TabIndex = 4;
            weekday4.Text = "Thu";
            weekday4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekday5
            // 
            weekday5.BackColor = Color.FromArgb(22, 33, 62);
            weekday5.Dock = DockStyle.Fill;
            weekday5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday5.ForeColor = Color.FromArgb(150, 150, 170);
            weekday5.Location = new Point(851, 1);
            weekday5.Margin = new Padding(1);
            weekday5.Name = "weekday5";
            weekday5.Size = new Size(168, 23);
            weekday5.TabIndex = 5;
            weekday5.Text = "Fri";
            weekday5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekday6
            // 
            weekday6.BackColor = Color.FromArgb(22, 33, 62);
            weekday6.Dock = DockStyle.Fill;
            weekday6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            weekday6.ForeColor = Color.FromArgb(150, 150, 170);
            weekday6.Location = new Point(1021, 1);
            weekday6.Margin = new Padding(1);
            weekday6.Name = "weekday6";
            weekday6.Size = new Size(170, 23);
            weekday6.TabIndex = 6;
            weekday6.Text = "Sat";
            weekday6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayCell00
            // 
            dayCell00.BackColor = Color.FromArgb(18, 23, 45);
            dayCell00.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell00.BorderWidth = 1;
            dayCell00.Controls.Add(dayEvents00);
            dayCell00.Controls.Add(dayNumber00);
            dayCell00.CornerRadius = 5;
            dayCell00.Cursor = Cursors.Hand;
            dayCell00.Dock = DockStyle.Fill;
            dayCell00.Location = new Point(1, 26);
            dayCell00.Margin = new Padding(1);
            dayCell00.Name = "dayCell00";
            dayCell00.Padding = new Padding(3);
            dayCell00.Size = new Size(168, 81);
            dayCell00.TabIndex = 7;
            dayCell00.Click += DayCell_Click;
            // 
            // dayEvents00
            // 
            dayEvents00.BackColor = Color.Transparent;
            dayEvents00.Controls.Add(eventChip00_0);
            dayEvents00.Controls.Add(eventChip00_1);
            dayEvents00.Controls.Add(moreEvents00);
            dayEvents00.Dock = DockStyle.Fill;
            dayEvents00.FlowDirection = FlowDirection.TopDown;
            dayEvents00.Location = new Point(3, 20);
            dayEvents00.Margin = new Padding(0);
            dayEvents00.Name = "dayEvents00";
            dayEvents00.Size = new Size(162, 58);
            dayEvents00.TabIndex = 0;
            dayEvents00.WrapContents = false;
            // 
            // eventChip00_0
            // 
            eventChip00_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip00_0.BorderColor = Color.White;
            eventChip00_0.BorderRadius = 5;
            eventChip00_0.Cursor = Cursors.Hand;
            eventChip00_0.FlatStyle = FlatStyle.Flat;
            eventChip00_0.Font = new Font("Segoe UI", 7F);
            eventChip00_0.ForeColor = Color.White;
            eventChip00_0.HoverColor = Color.Empty;
            eventChip00_0.Location = new Point(0, 1);
            eventChip00_0.Margin = new Padding(0, 1, 0, 1);
            eventChip00_0.Name = "eventChip00_0";
            eventChip00_0.PressedColor = Color.Empty;
            eventChip00_0.Size = new Size(145, 16);
            eventChip00_0.TabIndex = 0;
            eventChip00_0.Text = "Event title";
            eventChip00_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip00_0.UseVisualStyleBackColor = false;
            eventChip00_0.Click += EventChip_Click;
            // 
            // eventChip00_1
            // 
            eventChip00_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip00_1.BorderColor = Color.White;
            eventChip00_1.BorderRadius = 5;
            eventChip00_1.Cursor = Cursors.Hand;
            eventChip00_1.FlatStyle = FlatStyle.Flat;
            eventChip00_1.Font = new Font("Segoe UI", 7F);
            eventChip00_1.ForeColor = Color.White;
            eventChip00_1.HoverColor = Color.Empty;
            eventChip00_1.Location = new Point(0, 19);
            eventChip00_1.Margin = new Padding(0, 1, 0, 1);
            eventChip00_1.Name = "eventChip00_1";
            eventChip00_1.PressedColor = Color.Empty;
            eventChip00_1.Size = new Size(145, 16);
            eventChip00_1.TabIndex = 1;
            eventChip00_1.Text = "Another event";
            eventChip00_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip00_1.UseVisualStyleBackColor = false;
            eventChip00_1.Click += EventChip_Click;
            // 
            // moreEvents00
            // 
            moreEvents00.Cursor = Cursors.Hand;
            moreEvents00.Font = new Font("Segoe UI", 7F);
            moreEvents00.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents00.Location = new Point(3, 36);
            moreEvents00.Name = "moreEvents00";
            moreEvents00.Size = new Size(100, 15);
            moreEvents00.TabIndex = 2;
            moreEvents00.Text = "+1 more";
            moreEvents00.Click += DayCell_Click;
            // 
            // dayNumber00
            // 
            dayNumber00.BackColor = Color.Transparent;
            dayNumber00.Cursor = Cursors.Hand;
            dayNumber00.Dock = DockStyle.Top;
            dayNumber00.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber00.ForeColor = Color.White;
            dayNumber00.Location = new Point(3, 3);
            dayNumber00.Name = "dayNumber00";
            dayNumber00.Size = new Size(162, 17);
            dayNumber00.TabIndex = 1;
            dayNumber00.Text = "28";
            dayNumber00.Click += DayCell_Click;
            // 
            // dayCell01
            // 
            dayCell01.BackColor = Color.FromArgb(22, 33, 62);
            dayCell01.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell01.BorderWidth = 1;
            dayCell01.Controls.Add(dayEvents01);
            dayCell01.Controls.Add(dayNumber01);
            dayCell01.CornerRadius = 5;
            dayCell01.Cursor = Cursors.Hand;
            dayCell01.Dock = DockStyle.Fill;
            dayCell01.Location = new Point(171, 26);
            dayCell01.Margin = new Padding(1);
            dayCell01.Name = "dayCell01";
            dayCell01.Padding = new Padding(3);
            dayCell01.Size = new Size(168, 81);
            dayCell01.TabIndex = 8;
            dayCell01.Click += DayCell_Click;
            // 
            // dayEvents01
            // 
            dayEvents01.BackColor = Color.Transparent;
            dayEvents01.Controls.Add(eventChip01_0);
            dayEvents01.Controls.Add(eventChip01_1);
            dayEvents01.Controls.Add(moreEvents01);
            dayEvents01.Dock = DockStyle.Fill;
            dayEvents01.FlowDirection = FlowDirection.TopDown;
            dayEvents01.Location = new Point(3, 20);
            dayEvents01.Margin = new Padding(0);
            dayEvents01.Name = "dayEvents01";
            dayEvents01.Size = new Size(162, 58);
            dayEvents01.TabIndex = 0;
            dayEvents01.WrapContents = false;
            // 
            // eventChip01_0
            // 
            eventChip01_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip01_0.BorderColor = Color.White;
            eventChip01_0.BorderRadius = 5;
            eventChip01_0.Cursor = Cursors.Hand;
            eventChip01_0.FlatStyle = FlatStyle.Flat;
            eventChip01_0.Font = new Font("Segoe UI", 7F);
            eventChip01_0.ForeColor = Color.White;
            eventChip01_0.HoverColor = Color.Empty;
            eventChip01_0.Location = new Point(0, 1);
            eventChip01_0.Margin = new Padding(0, 1, 0, 1);
            eventChip01_0.Name = "eventChip01_0";
            eventChip01_0.PressedColor = Color.Empty;
            eventChip01_0.Size = new Size(145, 16);
            eventChip01_0.TabIndex = 0;
            eventChip01_0.Text = "Event title";
            eventChip01_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip01_0.UseVisualStyleBackColor = false;
            eventChip01_0.Click += EventChip_Click;
            // 
            // eventChip01_1
            // 
            eventChip01_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip01_1.BorderColor = Color.White;
            eventChip01_1.BorderRadius = 5;
            eventChip01_1.Cursor = Cursors.Hand;
            eventChip01_1.FlatStyle = FlatStyle.Flat;
            eventChip01_1.Font = new Font("Segoe UI", 7F);
            eventChip01_1.ForeColor = Color.White;
            eventChip01_1.HoverColor = Color.Empty;
            eventChip01_1.Location = new Point(0, 19);
            eventChip01_1.Margin = new Padding(0, 1, 0, 1);
            eventChip01_1.Name = "eventChip01_1";
            eventChip01_1.PressedColor = Color.Empty;
            eventChip01_1.Size = new Size(145, 16);
            eventChip01_1.TabIndex = 1;
            eventChip01_1.Text = "Another event";
            eventChip01_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip01_1.UseVisualStyleBackColor = false;
            eventChip01_1.Click += EventChip_Click;
            // 
            // moreEvents01
            // 
            moreEvents01.Cursor = Cursors.Hand;
            moreEvents01.Font = new Font("Segoe UI", 7F);
            moreEvents01.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents01.Location = new Point(3, 36);
            moreEvents01.Name = "moreEvents01";
            moreEvents01.Size = new Size(100, 15);
            moreEvents01.TabIndex = 2;
            moreEvents01.Text = "+1 more";
            moreEvents01.Click += DayCell_Click;
            // 
            // dayNumber01
            // 
            dayNumber01.BackColor = Color.Transparent;
            dayNumber01.Cursor = Cursors.Hand;
            dayNumber01.Dock = DockStyle.Top;
            dayNumber01.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber01.ForeColor = Color.White;
            dayNumber01.Location = new Point(3, 3);
            dayNumber01.Name = "dayNumber01";
            dayNumber01.Size = new Size(162, 17);
            dayNumber01.TabIndex = 1;
            dayNumber01.Text = "29";
            dayNumber01.Click += DayCell_Click;
            // 
            // dayCell02
            // 
            dayCell02.BackColor = Color.FromArgb(22, 33, 62);
            dayCell02.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell02.BorderWidth = 1;
            dayCell02.Controls.Add(dayEvents02);
            dayCell02.Controls.Add(dayNumber02);
            dayCell02.CornerRadius = 5;
            dayCell02.Cursor = Cursors.Hand;
            dayCell02.Dock = DockStyle.Fill;
            dayCell02.Location = new Point(341, 26);
            dayCell02.Margin = new Padding(1);
            dayCell02.Name = "dayCell02";
            dayCell02.Padding = new Padding(3);
            dayCell02.Size = new Size(168, 81);
            dayCell02.TabIndex = 9;
            dayCell02.Click += DayCell_Click;
            // 
            // dayEvents02
            // 
            dayEvents02.BackColor = Color.Transparent;
            dayEvents02.Controls.Add(eventChip02_0);
            dayEvents02.Controls.Add(eventChip02_1);
            dayEvents02.Controls.Add(moreEvents02);
            dayEvents02.Dock = DockStyle.Fill;
            dayEvents02.FlowDirection = FlowDirection.TopDown;
            dayEvents02.Location = new Point(3, 20);
            dayEvents02.Margin = new Padding(0);
            dayEvents02.Name = "dayEvents02";
            dayEvents02.Size = new Size(162, 58);
            dayEvents02.TabIndex = 0;
            dayEvents02.WrapContents = false;
            // 
            // eventChip02_0
            // 
            eventChip02_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip02_0.BorderColor = Color.White;
            eventChip02_0.BorderRadius = 5;
            eventChip02_0.Cursor = Cursors.Hand;
            eventChip02_0.FlatStyle = FlatStyle.Flat;
            eventChip02_0.Font = new Font("Segoe UI", 7F);
            eventChip02_0.ForeColor = Color.White;
            eventChip02_0.HoverColor = Color.Empty;
            eventChip02_0.Location = new Point(0, 1);
            eventChip02_0.Margin = new Padding(0, 1, 0, 1);
            eventChip02_0.Name = "eventChip02_0";
            eventChip02_0.PressedColor = Color.Empty;
            eventChip02_0.Size = new Size(145, 16);
            eventChip02_0.TabIndex = 0;
            eventChip02_0.Text = "Event title";
            eventChip02_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip02_0.UseVisualStyleBackColor = false;
            eventChip02_0.Click += EventChip_Click;
            // 
            // eventChip02_1
            // 
            eventChip02_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip02_1.BorderColor = Color.White;
            eventChip02_1.BorderRadius = 5;
            eventChip02_1.Cursor = Cursors.Hand;
            eventChip02_1.FlatStyle = FlatStyle.Flat;
            eventChip02_1.Font = new Font("Segoe UI", 7F);
            eventChip02_1.ForeColor = Color.White;
            eventChip02_1.HoverColor = Color.Empty;
            eventChip02_1.Location = new Point(0, 19);
            eventChip02_1.Margin = new Padding(0, 1, 0, 1);
            eventChip02_1.Name = "eventChip02_1";
            eventChip02_1.PressedColor = Color.Empty;
            eventChip02_1.Size = new Size(145, 16);
            eventChip02_1.TabIndex = 1;
            eventChip02_1.Text = "Another event";
            eventChip02_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip02_1.UseVisualStyleBackColor = false;
            eventChip02_1.Click += EventChip_Click;
            // 
            // moreEvents02
            // 
            moreEvents02.Cursor = Cursors.Hand;
            moreEvents02.Font = new Font("Segoe UI", 7F);
            moreEvents02.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents02.Location = new Point(3, 36);
            moreEvents02.Name = "moreEvents02";
            moreEvents02.Size = new Size(100, 15);
            moreEvents02.TabIndex = 2;
            moreEvents02.Text = "+1 more";
            moreEvents02.Click += DayCell_Click;
            // 
            // dayNumber02
            // 
            dayNumber02.BackColor = Color.Transparent;
            dayNumber02.Cursor = Cursors.Hand;
            dayNumber02.Dock = DockStyle.Top;
            dayNumber02.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber02.ForeColor = Color.White;
            dayNumber02.Location = new Point(3, 3);
            dayNumber02.Name = "dayNumber02";
            dayNumber02.Size = new Size(162, 17);
            dayNumber02.TabIndex = 1;
            dayNumber02.Text = "30";
            dayNumber02.Click += DayCell_Click;
            // 
            // dayCell03
            // 
            dayCell03.BackColor = Color.FromArgb(22, 33, 62);
            dayCell03.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell03.BorderWidth = 1;
            dayCell03.Controls.Add(dayEvents03);
            dayCell03.Controls.Add(dayNumber03);
            dayCell03.CornerRadius = 5;
            dayCell03.Cursor = Cursors.Hand;
            dayCell03.Dock = DockStyle.Fill;
            dayCell03.Location = new Point(511, 26);
            dayCell03.Margin = new Padding(1);
            dayCell03.Name = "dayCell03";
            dayCell03.Padding = new Padding(3);
            dayCell03.Size = new Size(168, 81);
            dayCell03.TabIndex = 10;
            dayCell03.Click += DayCell_Click;
            // 
            // dayEvents03
            // 
            dayEvents03.BackColor = Color.Transparent;
            dayEvents03.Controls.Add(eventChip03_0);
            dayEvents03.Controls.Add(eventChip03_1);
            dayEvents03.Controls.Add(moreEvents03);
            dayEvents03.Dock = DockStyle.Fill;
            dayEvents03.FlowDirection = FlowDirection.TopDown;
            dayEvents03.Location = new Point(3, 20);
            dayEvents03.Margin = new Padding(0);
            dayEvents03.Name = "dayEvents03";
            dayEvents03.Size = new Size(162, 58);
            dayEvents03.TabIndex = 0;
            dayEvents03.WrapContents = false;
            // 
            // eventChip03_0
            // 
            eventChip03_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip03_0.BorderColor = Color.White;
            eventChip03_0.BorderRadius = 5;
            eventChip03_0.Cursor = Cursors.Hand;
            eventChip03_0.FlatStyle = FlatStyle.Flat;
            eventChip03_0.Font = new Font("Segoe UI", 7F);
            eventChip03_0.ForeColor = Color.White;
            eventChip03_0.HoverColor = Color.Empty;
            eventChip03_0.Location = new Point(0, 1);
            eventChip03_0.Margin = new Padding(0, 1, 0, 1);
            eventChip03_0.Name = "eventChip03_0";
            eventChip03_0.PressedColor = Color.Empty;
            eventChip03_0.Size = new Size(145, 16);
            eventChip03_0.TabIndex = 0;
            eventChip03_0.Text = "Event title";
            eventChip03_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip03_0.UseVisualStyleBackColor = false;
            eventChip03_0.Click += EventChip_Click;
            // 
            // eventChip03_1
            // 
            eventChip03_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip03_1.BorderColor = Color.White;
            eventChip03_1.BorderRadius = 5;
            eventChip03_1.Cursor = Cursors.Hand;
            eventChip03_1.FlatStyle = FlatStyle.Flat;
            eventChip03_1.Font = new Font("Segoe UI", 7F);
            eventChip03_1.ForeColor = Color.White;
            eventChip03_1.HoverColor = Color.Empty;
            eventChip03_1.Location = new Point(0, 19);
            eventChip03_1.Margin = new Padding(0, 1, 0, 1);
            eventChip03_1.Name = "eventChip03_1";
            eventChip03_1.PressedColor = Color.Empty;
            eventChip03_1.Size = new Size(145, 16);
            eventChip03_1.TabIndex = 1;
            eventChip03_1.Text = "Another event";
            eventChip03_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip03_1.UseVisualStyleBackColor = false;
            eventChip03_1.Click += EventChip_Click;
            // 
            // moreEvents03
            // 
            moreEvents03.Cursor = Cursors.Hand;
            moreEvents03.Font = new Font("Segoe UI", 7F);
            moreEvents03.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents03.Location = new Point(3, 36);
            moreEvents03.Name = "moreEvents03";
            moreEvents03.Size = new Size(100, 15);
            moreEvents03.TabIndex = 2;
            moreEvents03.Text = "+1 more";
            moreEvents03.Click += DayCell_Click;
            // 
            // dayNumber03
            // 
            dayNumber03.BackColor = Color.Transparent;
            dayNumber03.Cursor = Cursors.Hand;
            dayNumber03.Dock = DockStyle.Top;
            dayNumber03.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber03.ForeColor = Color.White;
            dayNumber03.Location = new Point(3, 3);
            dayNumber03.Name = "dayNumber03";
            dayNumber03.Size = new Size(162, 17);
            dayNumber03.TabIndex = 1;
            dayNumber03.Text = "31";
            dayNumber03.Click += DayCell_Click;
            // 
            // dayCell04
            // 
            dayCell04.BackColor = Color.FromArgb(22, 33, 62);
            dayCell04.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell04.BorderWidth = 1;
            dayCell04.Controls.Add(dayEvents04);
            dayCell04.Controls.Add(dayNumber04);
            dayCell04.CornerRadius = 5;
            dayCell04.Cursor = Cursors.Hand;
            dayCell04.Dock = DockStyle.Fill;
            dayCell04.Location = new Point(681, 26);
            dayCell04.Margin = new Padding(1);
            dayCell04.Name = "dayCell04";
            dayCell04.Padding = new Padding(3);
            dayCell04.Size = new Size(168, 81);
            dayCell04.TabIndex = 11;
            dayCell04.Click += DayCell_Click;
            // 
            // dayEvents04
            // 
            dayEvents04.BackColor = Color.Transparent;
            dayEvents04.Controls.Add(eventChip04_0);
            dayEvents04.Controls.Add(eventChip04_1);
            dayEvents04.Controls.Add(moreEvents04);
            dayEvents04.Dock = DockStyle.Fill;
            dayEvents04.FlowDirection = FlowDirection.TopDown;
            dayEvents04.Location = new Point(3, 20);
            dayEvents04.Margin = new Padding(0);
            dayEvents04.Name = "dayEvents04";
            dayEvents04.Size = new Size(162, 58);
            dayEvents04.TabIndex = 0;
            dayEvents04.WrapContents = false;
            // 
            // eventChip04_0
            // 
            eventChip04_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip04_0.BorderColor = Color.White;
            eventChip04_0.BorderRadius = 5;
            eventChip04_0.Cursor = Cursors.Hand;
            eventChip04_0.FlatStyle = FlatStyle.Flat;
            eventChip04_0.Font = new Font("Segoe UI", 7F);
            eventChip04_0.ForeColor = Color.White;
            eventChip04_0.HoverColor = Color.Empty;
            eventChip04_0.Location = new Point(0, 1);
            eventChip04_0.Margin = new Padding(0, 1, 0, 1);
            eventChip04_0.Name = "eventChip04_0";
            eventChip04_0.PressedColor = Color.Empty;
            eventChip04_0.Size = new Size(145, 16);
            eventChip04_0.TabIndex = 0;
            eventChip04_0.Text = "Event title";
            eventChip04_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip04_0.UseVisualStyleBackColor = false;
            eventChip04_0.Click += EventChip_Click;
            // 
            // eventChip04_1
            // 
            eventChip04_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip04_1.BorderColor = Color.White;
            eventChip04_1.BorderRadius = 5;
            eventChip04_1.Cursor = Cursors.Hand;
            eventChip04_1.FlatStyle = FlatStyle.Flat;
            eventChip04_1.Font = new Font("Segoe UI", 7F);
            eventChip04_1.ForeColor = Color.White;
            eventChip04_1.HoverColor = Color.Empty;
            eventChip04_1.Location = new Point(0, 19);
            eventChip04_1.Margin = new Padding(0, 1, 0, 1);
            eventChip04_1.Name = "eventChip04_1";
            eventChip04_1.PressedColor = Color.Empty;
            eventChip04_1.Size = new Size(145, 16);
            eventChip04_1.TabIndex = 1;
            eventChip04_1.Text = "Another event";
            eventChip04_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip04_1.UseVisualStyleBackColor = false;
            eventChip04_1.Click += EventChip_Click;
            // 
            // moreEvents04
            // 
            moreEvents04.Cursor = Cursors.Hand;
            moreEvents04.Font = new Font("Segoe UI", 7F);
            moreEvents04.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents04.Location = new Point(3, 36);
            moreEvents04.Name = "moreEvents04";
            moreEvents04.Size = new Size(100, 15);
            moreEvents04.TabIndex = 2;
            moreEvents04.Text = "+1 more";
            moreEvents04.Click += DayCell_Click;
            // 
            // dayNumber04
            // 
            dayNumber04.BackColor = Color.Transparent;
            dayNumber04.Cursor = Cursors.Hand;
            dayNumber04.Dock = DockStyle.Top;
            dayNumber04.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber04.ForeColor = Color.White;
            dayNumber04.Location = new Point(3, 3);
            dayNumber04.Name = "dayNumber04";
            dayNumber04.Size = new Size(162, 17);
            dayNumber04.TabIndex = 1;
            dayNumber04.Text = "1";
            dayNumber04.Click += DayCell_Click;
            // 
            // dayCell05
            // 
            dayCell05.BackColor = Color.FromArgb(22, 33, 62);
            dayCell05.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell05.BorderWidth = 1;
            dayCell05.Controls.Add(dayEvents05);
            dayCell05.Controls.Add(dayNumber05);
            dayCell05.CornerRadius = 5;
            dayCell05.Cursor = Cursors.Hand;
            dayCell05.Dock = DockStyle.Fill;
            dayCell05.Location = new Point(851, 26);
            dayCell05.Margin = new Padding(1);
            dayCell05.Name = "dayCell05";
            dayCell05.Padding = new Padding(3);
            dayCell05.Size = new Size(168, 81);
            dayCell05.TabIndex = 12;
            dayCell05.Click += DayCell_Click;
            // 
            // dayEvents05
            // 
            dayEvents05.BackColor = Color.Transparent;
            dayEvents05.Controls.Add(eventChip05_0);
            dayEvents05.Controls.Add(eventChip05_1);
            dayEvents05.Controls.Add(moreEvents05);
            dayEvents05.Dock = DockStyle.Fill;
            dayEvents05.FlowDirection = FlowDirection.TopDown;
            dayEvents05.Location = new Point(3, 20);
            dayEvents05.Margin = new Padding(0);
            dayEvents05.Name = "dayEvents05";
            dayEvents05.Size = new Size(162, 58);
            dayEvents05.TabIndex = 0;
            dayEvents05.WrapContents = false;
            // 
            // eventChip05_0
            // 
            eventChip05_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip05_0.BorderColor = Color.White;
            eventChip05_0.BorderRadius = 5;
            eventChip05_0.Cursor = Cursors.Hand;
            eventChip05_0.FlatStyle = FlatStyle.Flat;
            eventChip05_0.Font = new Font("Segoe UI", 7F);
            eventChip05_0.ForeColor = Color.White;
            eventChip05_0.HoverColor = Color.Empty;
            eventChip05_0.Location = new Point(0, 1);
            eventChip05_0.Margin = new Padding(0, 1, 0, 1);
            eventChip05_0.Name = "eventChip05_0";
            eventChip05_0.PressedColor = Color.Empty;
            eventChip05_0.Size = new Size(145, 16);
            eventChip05_0.TabIndex = 0;
            eventChip05_0.Text = "Event title";
            eventChip05_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip05_0.UseVisualStyleBackColor = false;
            eventChip05_0.Click += EventChip_Click;
            // 
            // eventChip05_1
            // 
            eventChip05_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip05_1.BorderColor = Color.White;
            eventChip05_1.BorderRadius = 5;
            eventChip05_1.Cursor = Cursors.Hand;
            eventChip05_1.FlatStyle = FlatStyle.Flat;
            eventChip05_1.Font = new Font("Segoe UI", 7F);
            eventChip05_1.ForeColor = Color.White;
            eventChip05_1.HoverColor = Color.Empty;
            eventChip05_1.Location = new Point(0, 19);
            eventChip05_1.Margin = new Padding(0, 1, 0, 1);
            eventChip05_1.Name = "eventChip05_1";
            eventChip05_1.PressedColor = Color.Empty;
            eventChip05_1.Size = new Size(145, 16);
            eventChip05_1.TabIndex = 1;
            eventChip05_1.Text = "Another event";
            eventChip05_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip05_1.UseVisualStyleBackColor = false;
            eventChip05_1.Click += EventChip_Click;
            // 
            // moreEvents05
            // 
            moreEvents05.Cursor = Cursors.Hand;
            moreEvents05.Font = new Font("Segoe UI", 7F);
            moreEvents05.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents05.Location = new Point(3, 36);
            moreEvents05.Name = "moreEvents05";
            moreEvents05.Size = new Size(100, 15);
            moreEvents05.TabIndex = 2;
            moreEvents05.Text = "+1 more";
            moreEvents05.Click += DayCell_Click;
            // 
            // dayNumber05
            // 
            dayNumber05.BackColor = Color.Transparent;
            dayNumber05.Cursor = Cursors.Hand;
            dayNumber05.Dock = DockStyle.Top;
            dayNumber05.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber05.ForeColor = Color.White;
            dayNumber05.Location = new Point(3, 3);
            dayNumber05.Name = "dayNumber05";
            dayNumber05.Size = new Size(162, 17);
            dayNumber05.TabIndex = 1;
            dayNumber05.Text = "2";
            dayNumber05.Click += DayCell_Click;
            // 
            // dayCell06
            // 
            dayCell06.BackColor = Color.FromArgb(18, 23, 45);
            dayCell06.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell06.BorderWidth = 1;
            dayCell06.Controls.Add(dayEvents06);
            dayCell06.Controls.Add(dayNumber06);
            dayCell06.CornerRadius = 5;
            dayCell06.Cursor = Cursors.Hand;
            dayCell06.Dock = DockStyle.Fill;
            dayCell06.Location = new Point(1021, 26);
            dayCell06.Margin = new Padding(1);
            dayCell06.Name = "dayCell06";
            dayCell06.Padding = new Padding(3);
            dayCell06.Size = new Size(170, 81);
            dayCell06.TabIndex = 13;
            dayCell06.Click += DayCell_Click;
            // 
            // dayEvents06
            // 
            dayEvents06.BackColor = Color.Transparent;
            dayEvents06.Controls.Add(eventChip06_0);
            dayEvents06.Controls.Add(eventChip06_1);
            dayEvents06.Controls.Add(moreEvents06);
            dayEvents06.Dock = DockStyle.Fill;
            dayEvents06.FlowDirection = FlowDirection.TopDown;
            dayEvents06.Location = new Point(3, 20);
            dayEvents06.Margin = new Padding(0);
            dayEvents06.Name = "dayEvents06";
            dayEvents06.Size = new Size(164, 58);
            dayEvents06.TabIndex = 0;
            dayEvents06.WrapContents = false;
            // 
            // eventChip06_0
            // 
            eventChip06_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip06_0.BorderColor = Color.White;
            eventChip06_0.BorderRadius = 5;
            eventChip06_0.Cursor = Cursors.Hand;
            eventChip06_0.FlatStyle = FlatStyle.Flat;
            eventChip06_0.Font = new Font("Segoe UI", 7F);
            eventChip06_0.ForeColor = Color.White;
            eventChip06_0.HoverColor = Color.Empty;
            eventChip06_0.Location = new Point(0, 1);
            eventChip06_0.Margin = new Padding(0, 1, 0, 1);
            eventChip06_0.Name = "eventChip06_0";
            eventChip06_0.PressedColor = Color.Empty;
            eventChip06_0.Size = new Size(145, 16);
            eventChip06_0.TabIndex = 0;
            eventChip06_0.Text = "Event title";
            eventChip06_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip06_0.UseVisualStyleBackColor = false;
            eventChip06_0.Click += EventChip_Click;
            // 
            // eventChip06_1
            // 
            eventChip06_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip06_1.BorderColor = Color.White;
            eventChip06_1.BorderRadius = 5;
            eventChip06_1.Cursor = Cursors.Hand;
            eventChip06_1.FlatStyle = FlatStyle.Flat;
            eventChip06_1.Font = new Font("Segoe UI", 7F);
            eventChip06_1.ForeColor = Color.White;
            eventChip06_1.HoverColor = Color.Empty;
            eventChip06_1.Location = new Point(0, 19);
            eventChip06_1.Margin = new Padding(0, 1, 0, 1);
            eventChip06_1.Name = "eventChip06_1";
            eventChip06_1.PressedColor = Color.Empty;
            eventChip06_1.Size = new Size(145, 16);
            eventChip06_1.TabIndex = 1;
            eventChip06_1.Text = "Another event";
            eventChip06_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip06_1.UseVisualStyleBackColor = false;
            eventChip06_1.Click += EventChip_Click;
            // 
            // moreEvents06
            // 
            moreEvents06.Cursor = Cursors.Hand;
            moreEvents06.Font = new Font("Segoe UI", 7F);
            moreEvents06.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents06.Location = new Point(3, 36);
            moreEvents06.Name = "moreEvents06";
            moreEvents06.Size = new Size(100, 15);
            moreEvents06.TabIndex = 2;
            moreEvents06.Text = "+1 more";
            moreEvents06.Click += DayCell_Click;
            // 
            // dayNumber06
            // 
            dayNumber06.BackColor = Color.Transparent;
            dayNumber06.Cursor = Cursors.Hand;
            dayNumber06.Dock = DockStyle.Top;
            dayNumber06.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber06.ForeColor = Color.White;
            dayNumber06.Location = new Point(3, 3);
            dayNumber06.Name = "dayNumber06";
            dayNumber06.Size = new Size(164, 17);
            dayNumber06.TabIndex = 1;
            dayNumber06.Text = "3";
            dayNumber06.Click += DayCell_Click;
            // 
            // dayCell07
            // 
            dayCell07.BackColor = Color.FromArgb(18, 23, 45);
            dayCell07.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell07.BorderWidth = 1;
            dayCell07.Controls.Add(dayEvents07);
            dayCell07.Controls.Add(dayNumber07);
            dayCell07.CornerRadius = 5;
            dayCell07.Cursor = Cursors.Hand;
            dayCell07.Dock = DockStyle.Fill;
            dayCell07.Location = new Point(1, 109);
            dayCell07.Margin = new Padding(1);
            dayCell07.Name = "dayCell07";
            dayCell07.Padding = new Padding(3);
            dayCell07.Size = new Size(168, 81);
            dayCell07.TabIndex = 14;
            dayCell07.Click += DayCell_Click;
            // 
            // dayEvents07
            // 
            dayEvents07.BackColor = Color.Transparent;
            dayEvents07.Controls.Add(eventChip07_0);
            dayEvents07.Controls.Add(eventChip07_1);
            dayEvents07.Controls.Add(moreEvents07);
            dayEvents07.Dock = DockStyle.Fill;
            dayEvents07.FlowDirection = FlowDirection.TopDown;
            dayEvents07.Location = new Point(3, 20);
            dayEvents07.Margin = new Padding(0);
            dayEvents07.Name = "dayEvents07";
            dayEvents07.Size = new Size(162, 58);
            dayEvents07.TabIndex = 0;
            dayEvents07.WrapContents = false;
            // 
            // eventChip07_0
            // 
            eventChip07_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip07_0.BorderColor = Color.White;
            eventChip07_0.BorderRadius = 5;
            eventChip07_0.Cursor = Cursors.Hand;
            eventChip07_0.FlatStyle = FlatStyle.Flat;
            eventChip07_0.Font = new Font("Segoe UI", 7F);
            eventChip07_0.ForeColor = Color.White;
            eventChip07_0.HoverColor = Color.Empty;
            eventChip07_0.Location = new Point(0, 1);
            eventChip07_0.Margin = new Padding(0, 1, 0, 1);
            eventChip07_0.Name = "eventChip07_0";
            eventChip07_0.PressedColor = Color.Empty;
            eventChip07_0.Size = new Size(145, 16);
            eventChip07_0.TabIndex = 0;
            eventChip07_0.Text = "Event title";
            eventChip07_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip07_0.UseVisualStyleBackColor = false;
            eventChip07_0.Click += EventChip_Click;
            // 
            // eventChip07_1
            // 
            eventChip07_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip07_1.BorderColor = Color.White;
            eventChip07_1.BorderRadius = 5;
            eventChip07_1.Cursor = Cursors.Hand;
            eventChip07_1.FlatStyle = FlatStyle.Flat;
            eventChip07_1.Font = new Font("Segoe UI", 7F);
            eventChip07_1.ForeColor = Color.White;
            eventChip07_1.HoverColor = Color.Empty;
            eventChip07_1.Location = new Point(0, 19);
            eventChip07_1.Margin = new Padding(0, 1, 0, 1);
            eventChip07_1.Name = "eventChip07_1";
            eventChip07_1.PressedColor = Color.Empty;
            eventChip07_1.Size = new Size(145, 16);
            eventChip07_1.TabIndex = 1;
            eventChip07_1.Text = "Another event";
            eventChip07_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip07_1.UseVisualStyleBackColor = false;
            eventChip07_1.Click += EventChip_Click;
            // 
            // moreEvents07
            // 
            moreEvents07.Cursor = Cursors.Hand;
            moreEvents07.Font = new Font("Segoe UI", 7F);
            moreEvents07.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents07.Location = new Point(3, 36);
            moreEvents07.Name = "moreEvents07";
            moreEvents07.Size = new Size(100, 15);
            moreEvents07.TabIndex = 2;
            moreEvents07.Text = "+1 more";
            moreEvents07.Click += DayCell_Click;
            // 
            // dayNumber07
            // 
            dayNumber07.BackColor = Color.Transparent;
            dayNumber07.Cursor = Cursors.Hand;
            dayNumber07.Dock = DockStyle.Top;
            dayNumber07.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber07.ForeColor = Color.White;
            dayNumber07.Location = new Point(3, 3);
            dayNumber07.Name = "dayNumber07";
            dayNumber07.Size = new Size(162, 17);
            dayNumber07.TabIndex = 1;
            dayNumber07.Text = "4";
            dayNumber07.Click += DayCell_Click;
            // 
            // dayCell08
            // 
            dayCell08.BackColor = Color.FromArgb(22, 33, 62);
            dayCell08.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell08.BorderWidth = 1;
            dayCell08.Controls.Add(dayEvents08);
            dayCell08.Controls.Add(dayNumber08);
            dayCell08.CornerRadius = 5;
            dayCell08.Cursor = Cursors.Hand;
            dayCell08.Dock = DockStyle.Fill;
            dayCell08.Location = new Point(171, 109);
            dayCell08.Margin = new Padding(1);
            dayCell08.Name = "dayCell08";
            dayCell08.Padding = new Padding(3);
            dayCell08.Size = new Size(168, 81);
            dayCell08.TabIndex = 15;
            dayCell08.Click += DayCell_Click;
            // 
            // dayEvents08
            // 
            dayEvents08.BackColor = Color.Transparent;
            dayEvents08.Controls.Add(eventChip08_0);
            dayEvents08.Controls.Add(eventChip08_1);
            dayEvents08.Controls.Add(moreEvents08);
            dayEvents08.Dock = DockStyle.Fill;
            dayEvents08.FlowDirection = FlowDirection.TopDown;
            dayEvents08.Location = new Point(3, 20);
            dayEvents08.Margin = new Padding(0);
            dayEvents08.Name = "dayEvents08";
            dayEvents08.Size = new Size(162, 58);
            dayEvents08.TabIndex = 0;
            dayEvents08.WrapContents = false;
            // 
            // eventChip08_0
            // 
            eventChip08_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip08_0.BorderColor = Color.White;
            eventChip08_0.BorderRadius = 5;
            eventChip08_0.Cursor = Cursors.Hand;
            eventChip08_0.FlatStyle = FlatStyle.Flat;
            eventChip08_0.Font = new Font("Segoe UI", 7F);
            eventChip08_0.ForeColor = Color.White;
            eventChip08_0.HoverColor = Color.Empty;
            eventChip08_0.Location = new Point(0, 1);
            eventChip08_0.Margin = new Padding(0, 1, 0, 1);
            eventChip08_0.Name = "eventChip08_0";
            eventChip08_0.PressedColor = Color.Empty;
            eventChip08_0.Size = new Size(145, 16);
            eventChip08_0.TabIndex = 0;
            eventChip08_0.Text = "Event title";
            eventChip08_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip08_0.UseVisualStyleBackColor = false;
            eventChip08_0.Click += EventChip_Click;
            // 
            // eventChip08_1
            // 
            eventChip08_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip08_1.BorderColor = Color.White;
            eventChip08_1.BorderRadius = 5;
            eventChip08_1.Cursor = Cursors.Hand;
            eventChip08_1.FlatStyle = FlatStyle.Flat;
            eventChip08_1.Font = new Font("Segoe UI", 7F);
            eventChip08_1.ForeColor = Color.White;
            eventChip08_1.HoverColor = Color.Empty;
            eventChip08_1.Location = new Point(0, 19);
            eventChip08_1.Margin = new Padding(0, 1, 0, 1);
            eventChip08_1.Name = "eventChip08_1";
            eventChip08_1.PressedColor = Color.Empty;
            eventChip08_1.Size = new Size(145, 16);
            eventChip08_1.TabIndex = 1;
            eventChip08_1.Text = "Another event";
            eventChip08_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip08_1.UseVisualStyleBackColor = false;
            eventChip08_1.Click += EventChip_Click;
            // 
            // moreEvents08
            // 
            moreEvents08.Cursor = Cursors.Hand;
            moreEvents08.Font = new Font("Segoe UI", 7F);
            moreEvents08.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents08.Location = new Point(3, 36);
            moreEvents08.Name = "moreEvents08";
            moreEvents08.Size = new Size(100, 15);
            moreEvents08.TabIndex = 2;
            moreEvents08.Text = "+1 more";
            moreEvents08.Click += DayCell_Click;
            // 
            // dayNumber08
            // 
            dayNumber08.BackColor = Color.Transparent;
            dayNumber08.Cursor = Cursors.Hand;
            dayNumber08.Dock = DockStyle.Top;
            dayNumber08.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber08.ForeColor = Color.White;
            dayNumber08.Location = new Point(3, 3);
            dayNumber08.Name = "dayNumber08";
            dayNumber08.Size = new Size(162, 17);
            dayNumber08.TabIndex = 1;
            dayNumber08.Text = "5";
            dayNumber08.Click += DayCell_Click;
            // 
            // dayCell09
            // 
            dayCell09.BackColor = Color.FromArgb(22, 33, 62);
            dayCell09.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell09.BorderWidth = 1;
            dayCell09.Controls.Add(dayEvents09);
            dayCell09.Controls.Add(dayNumber09);
            dayCell09.CornerRadius = 5;
            dayCell09.Cursor = Cursors.Hand;
            dayCell09.Dock = DockStyle.Fill;
            dayCell09.Location = new Point(341, 109);
            dayCell09.Margin = new Padding(1);
            dayCell09.Name = "dayCell09";
            dayCell09.Padding = new Padding(3);
            dayCell09.Size = new Size(168, 81);
            dayCell09.TabIndex = 16;
            dayCell09.Click += DayCell_Click;
            // 
            // dayEvents09
            // 
            dayEvents09.BackColor = Color.Transparent;
            dayEvents09.Controls.Add(eventChip09_0);
            dayEvents09.Controls.Add(eventChip09_1);
            dayEvents09.Controls.Add(moreEvents09);
            dayEvents09.Dock = DockStyle.Fill;
            dayEvents09.FlowDirection = FlowDirection.TopDown;
            dayEvents09.Location = new Point(3, 20);
            dayEvents09.Margin = new Padding(0);
            dayEvents09.Name = "dayEvents09";
            dayEvents09.Size = new Size(162, 58);
            dayEvents09.TabIndex = 0;
            dayEvents09.WrapContents = false;
            // 
            // eventChip09_0
            // 
            eventChip09_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip09_0.BorderColor = Color.White;
            eventChip09_0.BorderRadius = 5;
            eventChip09_0.Cursor = Cursors.Hand;
            eventChip09_0.FlatStyle = FlatStyle.Flat;
            eventChip09_0.Font = new Font("Segoe UI", 7F);
            eventChip09_0.ForeColor = Color.White;
            eventChip09_0.HoverColor = Color.Empty;
            eventChip09_0.Location = new Point(0, 1);
            eventChip09_0.Margin = new Padding(0, 1, 0, 1);
            eventChip09_0.Name = "eventChip09_0";
            eventChip09_0.PressedColor = Color.Empty;
            eventChip09_0.Size = new Size(145, 16);
            eventChip09_0.TabIndex = 0;
            eventChip09_0.Text = "Event title";
            eventChip09_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip09_0.UseVisualStyleBackColor = false;
            eventChip09_0.Click += EventChip_Click;
            // 
            // eventChip09_1
            // 
            eventChip09_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip09_1.BorderColor = Color.White;
            eventChip09_1.BorderRadius = 5;
            eventChip09_1.Cursor = Cursors.Hand;
            eventChip09_1.FlatStyle = FlatStyle.Flat;
            eventChip09_1.Font = new Font("Segoe UI", 7F);
            eventChip09_1.ForeColor = Color.White;
            eventChip09_1.HoverColor = Color.Empty;
            eventChip09_1.Location = new Point(0, 19);
            eventChip09_1.Margin = new Padding(0, 1, 0, 1);
            eventChip09_1.Name = "eventChip09_1";
            eventChip09_1.PressedColor = Color.Empty;
            eventChip09_1.Size = new Size(145, 16);
            eventChip09_1.TabIndex = 1;
            eventChip09_1.Text = "Another event";
            eventChip09_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip09_1.UseVisualStyleBackColor = false;
            eventChip09_1.Click += EventChip_Click;
            // 
            // moreEvents09
            // 
            moreEvents09.Cursor = Cursors.Hand;
            moreEvents09.Font = new Font("Segoe UI", 7F);
            moreEvents09.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents09.Location = new Point(3, 36);
            moreEvents09.Name = "moreEvents09";
            moreEvents09.Size = new Size(100, 15);
            moreEvents09.TabIndex = 2;
            moreEvents09.Text = "+1 more";
            moreEvents09.Click += DayCell_Click;
            // 
            // dayNumber09
            // 
            dayNumber09.BackColor = Color.Transparent;
            dayNumber09.Cursor = Cursors.Hand;
            dayNumber09.Dock = DockStyle.Top;
            dayNumber09.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber09.ForeColor = Color.White;
            dayNumber09.Location = new Point(3, 3);
            dayNumber09.Name = "dayNumber09";
            dayNumber09.Size = new Size(162, 17);
            dayNumber09.TabIndex = 1;
            dayNumber09.Text = "6";
            dayNumber09.Click += DayCell_Click;
            // 
            // dayCell10
            // 
            dayCell10.BackColor = Color.FromArgb(22, 33, 62);
            dayCell10.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell10.BorderWidth = 1;
            dayCell10.Controls.Add(dayEvents10);
            dayCell10.Controls.Add(dayNumber10);
            dayCell10.CornerRadius = 5;
            dayCell10.Cursor = Cursors.Hand;
            dayCell10.Dock = DockStyle.Fill;
            dayCell10.Location = new Point(511, 109);
            dayCell10.Margin = new Padding(1);
            dayCell10.Name = "dayCell10";
            dayCell10.Padding = new Padding(3);
            dayCell10.Size = new Size(168, 81);
            dayCell10.TabIndex = 17;
            dayCell10.Click += DayCell_Click;
            // 
            // dayEvents10
            // 
            dayEvents10.BackColor = Color.Transparent;
            dayEvents10.Controls.Add(eventChip10_0);
            dayEvents10.Controls.Add(eventChip10_1);
            dayEvents10.Controls.Add(moreEvents10);
            dayEvents10.Dock = DockStyle.Fill;
            dayEvents10.FlowDirection = FlowDirection.TopDown;
            dayEvents10.Location = new Point(3, 20);
            dayEvents10.Margin = new Padding(0);
            dayEvents10.Name = "dayEvents10";
            dayEvents10.Size = new Size(162, 58);
            dayEvents10.TabIndex = 0;
            dayEvents10.WrapContents = false;
            // 
            // eventChip10_0
            // 
            eventChip10_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip10_0.BorderColor = Color.White;
            eventChip10_0.BorderRadius = 5;
            eventChip10_0.Cursor = Cursors.Hand;
            eventChip10_0.FlatStyle = FlatStyle.Flat;
            eventChip10_0.Font = new Font("Segoe UI", 7F);
            eventChip10_0.ForeColor = Color.White;
            eventChip10_0.HoverColor = Color.Empty;
            eventChip10_0.Location = new Point(0, 1);
            eventChip10_0.Margin = new Padding(0, 1, 0, 1);
            eventChip10_0.Name = "eventChip10_0";
            eventChip10_0.PressedColor = Color.Empty;
            eventChip10_0.Size = new Size(145, 16);
            eventChip10_0.TabIndex = 0;
            eventChip10_0.Text = "Event title";
            eventChip10_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip10_0.UseVisualStyleBackColor = false;
            eventChip10_0.Click += EventChip_Click;
            // 
            // eventChip10_1
            // 
            eventChip10_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip10_1.BorderColor = Color.White;
            eventChip10_1.BorderRadius = 5;
            eventChip10_1.Cursor = Cursors.Hand;
            eventChip10_1.FlatStyle = FlatStyle.Flat;
            eventChip10_1.Font = new Font("Segoe UI", 7F);
            eventChip10_1.ForeColor = Color.White;
            eventChip10_1.HoverColor = Color.Empty;
            eventChip10_1.Location = new Point(0, 19);
            eventChip10_1.Margin = new Padding(0, 1, 0, 1);
            eventChip10_1.Name = "eventChip10_1";
            eventChip10_1.PressedColor = Color.Empty;
            eventChip10_1.Size = new Size(145, 16);
            eventChip10_1.TabIndex = 1;
            eventChip10_1.Text = "Another event";
            eventChip10_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip10_1.UseVisualStyleBackColor = false;
            eventChip10_1.Click += EventChip_Click;
            // 
            // moreEvents10
            // 
            moreEvents10.Cursor = Cursors.Hand;
            moreEvents10.Font = new Font("Segoe UI", 7F);
            moreEvents10.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents10.Location = new Point(3, 36);
            moreEvents10.Name = "moreEvents10";
            moreEvents10.Size = new Size(100, 15);
            moreEvents10.TabIndex = 2;
            moreEvents10.Text = "+1 more";
            moreEvents10.Click += DayCell_Click;
            // 
            // dayNumber10
            // 
            dayNumber10.BackColor = Color.Transparent;
            dayNumber10.Cursor = Cursors.Hand;
            dayNumber10.Dock = DockStyle.Top;
            dayNumber10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber10.ForeColor = Color.White;
            dayNumber10.Location = new Point(3, 3);
            dayNumber10.Name = "dayNumber10";
            dayNumber10.Size = new Size(162, 17);
            dayNumber10.TabIndex = 1;
            dayNumber10.Text = "7";
            dayNumber10.Click += DayCell_Click;
            // 
            // dayCell11
            // 
            dayCell11.BackColor = Color.FromArgb(22, 33, 62);
            dayCell11.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell11.BorderWidth = 1;
            dayCell11.Controls.Add(dayEvents11);
            dayCell11.Controls.Add(dayNumber11);
            dayCell11.CornerRadius = 5;
            dayCell11.Cursor = Cursors.Hand;
            dayCell11.Dock = DockStyle.Fill;
            dayCell11.Location = new Point(681, 109);
            dayCell11.Margin = new Padding(1);
            dayCell11.Name = "dayCell11";
            dayCell11.Padding = new Padding(3);
            dayCell11.Size = new Size(168, 81);
            dayCell11.TabIndex = 18;
            dayCell11.Click += DayCell_Click;
            // 
            // dayEvents11
            // 
            dayEvents11.BackColor = Color.Transparent;
            dayEvents11.Controls.Add(eventChip11_0);
            dayEvents11.Controls.Add(eventChip11_1);
            dayEvents11.Controls.Add(moreEvents11);
            dayEvents11.Dock = DockStyle.Fill;
            dayEvents11.FlowDirection = FlowDirection.TopDown;
            dayEvents11.Location = new Point(3, 20);
            dayEvents11.Margin = new Padding(0);
            dayEvents11.Name = "dayEvents11";
            dayEvents11.Size = new Size(162, 58);
            dayEvents11.TabIndex = 0;
            dayEvents11.WrapContents = false;
            // 
            // eventChip11_0
            // 
            eventChip11_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip11_0.BorderColor = Color.White;
            eventChip11_0.BorderRadius = 5;
            eventChip11_0.Cursor = Cursors.Hand;
            eventChip11_0.FlatStyle = FlatStyle.Flat;
            eventChip11_0.Font = new Font("Segoe UI", 7F);
            eventChip11_0.ForeColor = Color.White;
            eventChip11_0.HoverColor = Color.Empty;
            eventChip11_0.Location = new Point(0, 1);
            eventChip11_0.Margin = new Padding(0, 1, 0, 1);
            eventChip11_0.Name = "eventChip11_0";
            eventChip11_0.PressedColor = Color.Empty;
            eventChip11_0.Size = new Size(145, 16);
            eventChip11_0.TabIndex = 0;
            eventChip11_0.Text = "Event title";
            eventChip11_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip11_0.UseVisualStyleBackColor = false;
            eventChip11_0.Click += EventChip_Click;
            // 
            // eventChip11_1
            // 
            eventChip11_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip11_1.BorderColor = Color.White;
            eventChip11_1.BorderRadius = 5;
            eventChip11_1.Cursor = Cursors.Hand;
            eventChip11_1.FlatStyle = FlatStyle.Flat;
            eventChip11_1.Font = new Font("Segoe UI", 7F);
            eventChip11_1.ForeColor = Color.White;
            eventChip11_1.HoverColor = Color.Empty;
            eventChip11_1.Location = new Point(0, 19);
            eventChip11_1.Margin = new Padding(0, 1, 0, 1);
            eventChip11_1.Name = "eventChip11_1";
            eventChip11_1.PressedColor = Color.Empty;
            eventChip11_1.Size = new Size(145, 16);
            eventChip11_1.TabIndex = 1;
            eventChip11_1.Text = "Another event";
            eventChip11_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip11_1.UseVisualStyleBackColor = false;
            eventChip11_1.Click += EventChip_Click;
            // 
            // moreEvents11
            // 
            moreEvents11.Cursor = Cursors.Hand;
            moreEvents11.Font = new Font("Segoe UI", 7F);
            moreEvents11.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents11.Location = new Point(3, 36);
            moreEvents11.Name = "moreEvents11";
            moreEvents11.Size = new Size(100, 15);
            moreEvents11.TabIndex = 2;
            moreEvents11.Text = "+1 more";
            moreEvents11.Click += DayCell_Click;
            // 
            // dayNumber11
            // 
            dayNumber11.BackColor = Color.Transparent;
            dayNumber11.Cursor = Cursors.Hand;
            dayNumber11.Dock = DockStyle.Top;
            dayNumber11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber11.ForeColor = Color.White;
            dayNumber11.Location = new Point(3, 3);
            dayNumber11.Name = "dayNumber11";
            dayNumber11.Size = new Size(162, 17);
            dayNumber11.TabIndex = 1;
            dayNumber11.Text = "8";
            dayNumber11.Click += DayCell_Click;
            // 
            // dayCell12
            // 
            dayCell12.BackColor = Color.FromArgb(22, 33, 62);
            dayCell12.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell12.BorderWidth = 1;
            dayCell12.Controls.Add(dayEvents12);
            dayCell12.Controls.Add(dayNumber12);
            dayCell12.CornerRadius = 5;
            dayCell12.Cursor = Cursors.Hand;
            dayCell12.Dock = DockStyle.Fill;
            dayCell12.Location = new Point(851, 109);
            dayCell12.Margin = new Padding(1);
            dayCell12.Name = "dayCell12";
            dayCell12.Padding = new Padding(3);
            dayCell12.Size = new Size(168, 81);
            dayCell12.TabIndex = 19;
            dayCell12.Click += DayCell_Click;
            // 
            // dayEvents12
            // 
            dayEvents12.BackColor = Color.Transparent;
            dayEvents12.Controls.Add(eventChip12_0);
            dayEvents12.Controls.Add(eventChip12_1);
            dayEvents12.Controls.Add(moreEvents12);
            dayEvents12.Dock = DockStyle.Fill;
            dayEvents12.FlowDirection = FlowDirection.TopDown;
            dayEvents12.Location = new Point(3, 20);
            dayEvents12.Margin = new Padding(0);
            dayEvents12.Name = "dayEvents12";
            dayEvents12.Size = new Size(162, 58);
            dayEvents12.TabIndex = 0;
            dayEvents12.WrapContents = false;
            // 
            // eventChip12_0
            // 
            eventChip12_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip12_0.BorderColor = Color.White;
            eventChip12_0.BorderRadius = 5;
            eventChip12_0.Cursor = Cursors.Hand;
            eventChip12_0.FlatStyle = FlatStyle.Flat;
            eventChip12_0.Font = new Font("Segoe UI", 7F);
            eventChip12_0.ForeColor = Color.White;
            eventChip12_0.HoverColor = Color.Empty;
            eventChip12_0.Location = new Point(0, 1);
            eventChip12_0.Margin = new Padding(0, 1, 0, 1);
            eventChip12_0.Name = "eventChip12_0";
            eventChip12_0.PressedColor = Color.Empty;
            eventChip12_0.Size = new Size(145, 16);
            eventChip12_0.TabIndex = 0;
            eventChip12_0.Text = "Event title";
            eventChip12_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip12_0.UseVisualStyleBackColor = false;
            eventChip12_0.Click += EventChip_Click;
            // 
            // eventChip12_1
            // 
            eventChip12_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip12_1.BorderColor = Color.White;
            eventChip12_1.BorderRadius = 5;
            eventChip12_1.Cursor = Cursors.Hand;
            eventChip12_1.FlatStyle = FlatStyle.Flat;
            eventChip12_1.Font = new Font("Segoe UI", 7F);
            eventChip12_1.ForeColor = Color.White;
            eventChip12_1.HoverColor = Color.Empty;
            eventChip12_1.Location = new Point(0, 19);
            eventChip12_1.Margin = new Padding(0, 1, 0, 1);
            eventChip12_1.Name = "eventChip12_1";
            eventChip12_1.PressedColor = Color.Empty;
            eventChip12_1.Size = new Size(145, 16);
            eventChip12_1.TabIndex = 1;
            eventChip12_1.Text = "Another event";
            eventChip12_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip12_1.UseVisualStyleBackColor = false;
            eventChip12_1.Click += EventChip_Click;
            // 
            // moreEvents12
            // 
            moreEvents12.Cursor = Cursors.Hand;
            moreEvents12.Font = new Font("Segoe UI", 7F);
            moreEvents12.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents12.Location = new Point(3, 36);
            moreEvents12.Name = "moreEvents12";
            moreEvents12.Size = new Size(100, 15);
            moreEvents12.TabIndex = 2;
            moreEvents12.Text = "+1 more";
            moreEvents12.Click += DayCell_Click;
            // 
            // dayNumber12
            // 
            dayNumber12.BackColor = Color.Transparent;
            dayNumber12.Cursor = Cursors.Hand;
            dayNumber12.Dock = DockStyle.Top;
            dayNumber12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber12.ForeColor = Color.White;
            dayNumber12.Location = new Point(3, 3);
            dayNumber12.Name = "dayNumber12";
            dayNumber12.Size = new Size(162, 17);
            dayNumber12.TabIndex = 1;
            dayNumber12.Text = "9";
            dayNumber12.Click += DayCell_Click;
            // 
            // dayCell13
            // 
            dayCell13.BackColor = Color.FromArgb(18, 23, 45);
            dayCell13.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell13.BorderWidth = 1;
            dayCell13.Controls.Add(dayEvents13);
            dayCell13.Controls.Add(dayNumber13);
            dayCell13.CornerRadius = 5;
            dayCell13.Cursor = Cursors.Hand;
            dayCell13.Dock = DockStyle.Fill;
            dayCell13.Location = new Point(1021, 109);
            dayCell13.Margin = new Padding(1);
            dayCell13.Name = "dayCell13";
            dayCell13.Padding = new Padding(3);
            dayCell13.Size = new Size(170, 81);
            dayCell13.TabIndex = 20;
            dayCell13.Click += DayCell_Click;
            // 
            // dayEvents13
            // 
            dayEvents13.BackColor = Color.Transparent;
            dayEvents13.Controls.Add(eventChip13_0);
            dayEvents13.Controls.Add(eventChip13_1);
            dayEvents13.Controls.Add(moreEvents13);
            dayEvents13.Dock = DockStyle.Fill;
            dayEvents13.FlowDirection = FlowDirection.TopDown;
            dayEvents13.Location = new Point(3, 20);
            dayEvents13.Margin = new Padding(0);
            dayEvents13.Name = "dayEvents13";
            dayEvents13.Size = new Size(164, 58);
            dayEvents13.TabIndex = 0;
            dayEvents13.WrapContents = false;
            // 
            // eventChip13_0
            // 
            eventChip13_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip13_0.BorderColor = Color.White;
            eventChip13_0.BorderRadius = 5;
            eventChip13_0.Cursor = Cursors.Hand;
            eventChip13_0.FlatStyle = FlatStyle.Flat;
            eventChip13_0.Font = new Font("Segoe UI", 7F);
            eventChip13_0.ForeColor = Color.White;
            eventChip13_0.HoverColor = Color.Empty;
            eventChip13_0.Location = new Point(0, 1);
            eventChip13_0.Margin = new Padding(0, 1, 0, 1);
            eventChip13_0.Name = "eventChip13_0";
            eventChip13_0.PressedColor = Color.Empty;
            eventChip13_0.Size = new Size(145, 16);
            eventChip13_0.TabIndex = 0;
            eventChip13_0.Text = "Event title";
            eventChip13_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip13_0.UseVisualStyleBackColor = false;
            eventChip13_0.Click += EventChip_Click;
            // 
            // eventChip13_1
            // 
            eventChip13_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip13_1.BorderColor = Color.White;
            eventChip13_1.BorderRadius = 5;
            eventChip13_1.Cursor = Cursors.Hand;
            eventChip13_1.FlatStyle = FlatStyle.Flat;
            eventChip13_1.Font = new Font("Segoe UI", 7F);
            eventChip13_1.ForeColor = Color.White;
            eventChip13_1.HoverColor = Color.Empty;
            eventChip13_1.Location = new Point(0, 19);
            eventChip13_1.Margin = new Padding(0, 1, 0, 1);
            eventChip13_1.Name = "eventChip13_1";
            eventChip13_1.PressedColor = Color.Empty;
            eventChip13_1.Size = new Size(145, 16);
            eventChip13_1.TabIndex = 1;
            eventChip13_1.Text = "Another event";
            eventChip13_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip13_1.UseVisualStyleBackColor = false;
            eventChip13_1.Click += EventChip_Click;
            // 
            // moreEvents13
            // 
            moreEvents13.Cursor = Cursors.Hand;
            moreEvents13.Font = new Font("Segoe UI", 7F);
            moreEvents13.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents13.Location = new Point(3, 36);
            moreEvents13.Name = "moreEvents13";
            moreEvents13.Size = new Size(100, 15);
            moreEvents13.TabIndex = 2;
            moreEvents13.Text = "+1 more";
            moreEvents13.Click += DayCell_Click;
            // 
            // dayNumber13
            // 
            dayNumber13.BackColor = Color.Transparent;
            dayNumber13.Cursor = Cursors.Hand;
            dayNumber13.Dock = DockStyle.Top;
            dayNumber13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber13.ForeColor = Color.White;
            dayNumber13.Location = new Point(3, 3);
            dayNumber13.Name = "dayNumber13";
            dayNumber13.Size = new Size(164, 17);
            dayNumber13.TabIndex = 1;
            dayNumber13.Text = "10";
            dayNumber13.Click += DayCell_Click;
            // 
            // dayCell14
            // 
            dayCell14.BackColor = Color.FromArgb(18, 23, 45);
            dayCell14.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell14.BorderWidth = 1;
            dayCell14.Controls.Add(dayEvents14);
            dayCell14.Controls.Add(dayNumber14);
            dayCell14.CornerRadius = 5;
            dayCell14.Cursor = Cursors.Hand;
            dayCell14.Dock = DockStyle.Fill;
            dayCell14.Location = new Point(1, 192);
            dayCell14.Margin = new Padding(1);
            dayCell14.Name = "dayCell14";
            dayCell14.Padding = new Padding(3);
            dayCell14.Size = new Size(168, 81);
            dayCell14.TabIndex = 21;
            dayCell14.Click += DayCell_Click;
            // 
            // dayEvents14
            // 
            dayEvents14.BackColor = Color.Transparent;
            dayEvents14.Controls.Add(eventChip14_0);
            dayEvents14.Controls.Add(eventChip14_1);
            dayEvents14.Controls.Add(moreEvents14);
            dayEvents14.Dock = DockStyle.Fill;
            dayEvents14.FlowDirection = FlowDirection.TopDown;
            dayEvents14.Location = new Point(3, 20);
            dayEvents14.Margin = new Padding(0);
            dayEvents14.Name = "dayEvents14";
            dayEvents14.Size = new Size(162, 58);
            dayEvents14.TabIndex = 0;
            dayEvents14.WrapContents = false;
            // 
            // eventChip14_0
            // 
            eventChip14_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip14_0.BorderColor = Color.White;
            eventChip14_0.BorderRadius = 5;
            eventChip14_0.Cursor = Cursors.Hand;
            eventChip14_0.FlatStyle = FlatStyle.Flat;
            eventChip14_0.Font = new Font("Segoe UI", 7F);
            eventChip14_0.ForeColor = Color.White;
            eventChip14_0.HoverColor = Color.Empty;
            eventChip14_0.Location = new Point(0, 1);
            eventChip14_0.Margin = new Padding(0, 1, 0, 1);
            eventChip14_0.Name = "eventChip14_0";
            eventChip14_0.PressedColor = Color.Empty;
            eventChip14_0.Size = new Size(145, 16);
            eventChip14_0.TabIndex = 0;
            eventChip14_0.Text = "Event title";
            eventChip14_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip14_0.UseVisualStyleBackColor = false;
            eventChip14_0.Click += EventChip_Click;
            // 
            // eventChip14_1
            // 
            eventChip14_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip14_1.BorderColor = Color.White;
            eventChip14_1.BorderRadius = 5;
            eventChip14_1.Cursor = Cursors.Hand;
            eventChip14_1.FlatStyle = FlatStyle.Flat;
            eventChip14_1.Font = new Font("Segoe UI", 7F);
            eventChip14_1.ForeColor = Color.White;
            eventChip14_1.HoverColor = Color.Empty;
            eventChip14_1.Location = new Point(0, 19);
            eventChip14_1.Margin = new Padding(0, 1, 0, 1);
            eventChip14_1.Name = "eventChip14_1";
            eventChip14_1.PressedColor = Color.Empty;
            eventChip14_1.Size = new Size(145, 16);
            eventChip14_1.TabIndex = 1;
            eventChip14_1.Text = "Another event";
            eventChip14_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip14_1.UseVisualStyleBackColor = false;
            eventChip14_1.Click += EventChip_Click;
            // 
            // moreEvents14
            // 
            moreEvents14.Cursor = Cursors.Hand;
            moreEvents14.Font = new Font("Segoe UI", 7F);
            moreEvents14.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents14.Location = new Point(3, 36);
            moreEvents14.Name = "moreEvents14";
            moreEvents14.Size = new Size(100, 15);
            moreEvents14.TabIndex = 2;
            moreEvents14.Text = "+1 more";
            moreEvents14.Click += DayCell_Click;
            // 
            // dayNumber14
            // 
            dayNumber14.BackColor = Color.Transparent;
            dayNumber14.Cursor = Cursors.Hand;
            dayNumber14.Dock = DockStyle.Top;
            dayNumber14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber14.ForeColor = Color.White;
            dayNumber14.Location = new Point(3, 3);
            dayNumber14.Name = "dayNumber14";
            dayNumber14.Size = new Size(162, 17);
            dayNumber14.TabIndex = 1;
            dayNumber14.Text = "11";
            dayNumber14.Click += DayCell_Click;
            // 
            // dayCell15
            // 
            dayCell15.BackColor = Color.FromArgb(22, 33, 62);
            dayCell15.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell15.BorderWidth = 1;
            dayCell15.Controls.Add(dayEvents15);
            dayCell15.Controls.Add(dayNumber15);
            dayCell15.CornerRadius = 5;
            dayCell15.Cursor = Cursors.Hand;
            dayCell15.Dock = DockStyle.Fill;
            dayCell15.Location = new Point(171, 192);
            dayCell15.Margin = new Padding(1);
            dayCell15.Name = "dayCell15";
            dayCell15.Padding = new Padding(3);
            dayCell15.Size = new Size(168, 81);
            dayCell15.TabIndex = 22;
            dayCell15.Click += DayCell_Click;
            // 
            // dayEvents15
            // 
            dayEvents15.BackColor = Color.Transparent;
            dayEvents15.Controls.Add(eventChip15_0);
            dayEvents15.Controls.Add(eventChip15_1);
            dayEvents15.Controls.Add(moreEvents15);
            dayEvents15.Dock = DockStyle.Fill;
            dayEvents15.FlowDirection = FlowDirection.TopDown;
            dayEvents15.Location = new Point(3, 20);
            dayEvents15.Margin = new Padding(0);
            dayEvents15.Name = "dayEvents15";
            dayEvents15.Size = new Size(162, 58);
            dayEvents15.TabIndex = 0;
            dayEvents15.WrapContents = false;
            // 
            // eventChip15_0
            // 
            eventChip15_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip15_0.BorderColor = Color.White;
            eventChip15_0.BorderRadius = 5;
            eventChip15_0.Cursor = Cursors.Hand;
            eventChip15_0.FlatStyle = FlatStyle.Flat;
            eventChip15_0.Font = new Font("Segoe UI", 7F);
            eventChip15_0.ForeColor = Color.White;
            eventChip15_0.HoverColor = Color.Empty;
            eventChip15_0.Location = new Point(0, 1);
            eventChip15_0.Margin = new Padding(0, 1, 0, 1);
            eventChip15_0.Name = "eventChip15_0";
            eventChip15_0.PressedColor = Color.Empty;
            eventChip15_0.Size = new Size(145, 16);
            eventChip15_0.TabIndex = 0;
            eventChip15_0.Text = "Event title";
            eventChip15_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip15_0.UseVisualStyleBackColor = false;
            eventChip15_0.Click += EventChip_Click;
            // 
            // eventChip15_1
            // 
            eventChip15_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip15_1.BorderColor = Color.White;
            eventChip15_1.BorderRadius = 5;
            eventChip15_1.Cursor = Cursors.Hand;
            eventChip15_1.FlatStyle = FlatStyle.Flat;
            eventChip15_1.Font = new Font("Segoe UI", 7F);
            eventChip15_1.ForeColor = Color.White;
            eventChip15_1.HoverColor = Color.Empty;
            eventChip15_1.Location = new Point(0, 19);
            eventChip15_1.Margin = new Padding(0, 1, 0, 1);
            eventChip15_1.Name = "eventChip15_1";
            eventChip15_1.PressedColor = Color.Empty;
            eventChip15_1.Size = new Size(145, 16);
            eventChip15_1.TabIndex = 1;
            eventChip15_1.Text = "Another event";
            eventChip15_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip15_1.UseVisualStyleBackColor = false;
            eventChip15_1.Click += EventChip_Click;
            // 
            // moreEvents15
            // 
            moreEvents15.Cursor = Cursors.Hand;
            moreEvents15.Font = new Font("Segoe UI", 7F);
            moreEvents15.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents15.Location = new Point(3, 36);
            moreEvents15.Name = "moreEvents15";
            moreEvents15.Size = new Size(100, 15);
            moreEvents15.TabIndex = 2;
            moreEvents15.Text = "+1 more";
            moreEvents15.Click += DayCell_Click;
            // 
            // dayNumber15
            // 
            dayNumber15.BackColor = Color.Transparent;
            dayNumber15.Cursor = Cursors.Hand;
            dayNumber15.Dock = DockStyle.Top;
            dayNumber15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber15.ForeColor = Color.White;
            dayNumber15.Location = new Point(3, 3);
            dayNumber15.Name = "dayNumber15";
            dayNumber15.Size = new Size(162, 17);
            dayNumber15.TabIndex = 1;
            dayNumber15.Text = "12";
            dayNumber15.Click += DayCell_Click;
            // 
            // dayCell16
            // 
            dayCell16.BackColor = Color.FromArgb(22, 33, 62);
            dayCell16.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell16.BorderWidth = 1;
            dayCell16.Controls.Add(dayEvents16);
            dayCell16.Controls.Add(dayNumber16);
            dayCell16.CornerRadius = 5;
            dayCell16.Cursor = Cursors.Hand;
            dayCell16.Dock = DockStyle.Fill;
            dayCell16.Location = new Point(341, 192);
            dayCell16.Margin = new Padding(1);
            dayCell16.Name = "dayCell16";
            dayCell16.Padding = new Padding(3);
            dayCell16.Size = new Size(168, 81);
            dayCell16.TabIndex = 23;
            dayCell16.Click += DayCell_Click;
            // 
            // dayEvents16
            // 
            dayEvents16.BackColor = Color.Transparent;
            dayEvents16.Controls.Add(eventChip16_0);
            dayEvents16.Controls.Add(eventChip16_1);
            dayEvents16.Controls.Add(moreEvents16);
            dayEvents16.Dock = DockStyle.Fill;
            dayEvents16.FlowDirection = FlowDirection.TopDown;
            dayEvents16.Location = new Point(3, 20);
            dayEvents16.Margin = new Padding(0);
            dayEvents16.Name = "dayEvents16";
            dayEvents16.Size = new Size(162, 58);
            dayEvents16.TabIndex = 0;
            dayEvents16.WrapContents = false;
            // 
            // eventChip16_0
            // 
            eventChip16_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip16_0.BorderColor = Color.White;
            eventChip16_0.BorderRadius = 5;
            eventChip16_0.Cursor = Cursors.Hand;
            eventChip16_0.FlatStyle = FlatStyle.Flat;
            eventChip16_0.Font = new Font("Segoe UI", 7F);
            eventChip16_0.ForeColor = Color.White;
            eventChip16_0.HoverColor = Color.Empty;
            eventChip16_0.Location = new Point(0, 1);
            eventChip16_0.Margin = new Padding(0, 1, 0, 1);
            eventChip16_0.Name = "eventChip16_0";
            eventChip16_0.PressedColor = Color.Empty;
            eventChip16_0.Size = new Size(145, 16);
            eventChip16_0.TabIndex = 0;
            eventChip16_0.Text = "Event title";
            eventChip16_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip16_0.UseVisualStyleBackColor = false;
            eventChip16_0.Click += EventChip_Click;
            // 
            // eventChip16_1
            // 
            eventChip16_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip16_1.BorderColor = Color.White;
            eventChip16_1.BorderRadius = 5;
            eventChip16_1.Cursor = Cursors.Hand;
            eventChip16_1.FlatStyle = FlatStyle.Flat;
            eventChip16_1.Font = new Font("Segoe UI", 7F);
            eventChip16_1.ForeColor = Color.White;
            eventChip16_1.HoverColor = Color.Empty;
            eventChip16_1.Location = new Point(0, 19);
            eventChip16_1.Margin = new Padding(0, 1, 0, 1);
            eventChip16_1.Name = "eventChip16_1";
            eventChip16_1.PressedColor = Color.Empty;
            eventChip16_1.Size = new Size(145, 16);
            eventChip16_1.TabIndex = 1;
            eventChip16_1.Text = "Another event";
            eventChip16_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip16_1.UseVisualStyleBackColor = false;
            eventChip16_1.Click += EventChip_Click;
            // 
            // moreEvents16
            // 
            moreEvents16.Cursor = Cursors.Hand;
            moreEvents16.Font = new Font("Segoe UI", 7F);
            moreEvents16.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents16.Location = new Point(3, 36);
            moreEvents16.Name = "moreEvents16";
            moreEvents16.Size = new Size(100, 15);
            moreEvents16.TabIndex = 2;
            moreEvents16.Text = "+1 more";
            moreEvents16.Click += DayCell_Click;
            // 
            // dayNumber16
            // 
            dayNumber16.BackColor = Color.Transparent;
            dayNumber16.Cursor = Cursors.Hand;
            dayNumber16.Dock = DockStyle.Top;
            dayNumber16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber16.ForeColor = Color.White;
            dayNumber16.Location = new Point(3, 3);
            dayNumber16.Name = "dayNumber16";
            dayNumber16.Size = new Size(162, 17);
            dayNumber16.TabIndex = 1;
            dayNumber16.Text = "13";
            dayNumber16.Click += DayCell_Click;
            // 
            // dayCell17
            // 
            dayCell17.BackColor = Color.FromArgb(22, 33, 62);
            dayCell17.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell17.BorderWidth = 1;
            dayCell17.Controls.Add(dayEvents17);
            dayCell17.Controls.Add(dayNumber17);
            dayCell17.CornerRadius = 5;
            dayCell17.Cursor = Cursors.Hand;
            dayCell17.Dock = DockStyle.Fill;
            dayCell17.Location = new Point(511, 192);
            dayCell17.Margin = new Padding(1);
            dayCell17.Name = "dayCell17";
            dayCell17.Padding = new Padding(3);
            dayCell17.Size = new Size(168, 81);
            dayCell17.TabIndex = 24;
            dayCell17.Click += DayCell_Click;
            // 
            // dayEvents17
            // 
            dayEvents17.BackColor = Color.Transparent;
            dayEvents17.Controls.Add(eventChip17_0);
            dayEvents17.Controls.Add(eventChip17_1);
            dayEvents17.Controls.Add(moreEvents17);
            dayEvents17.Dock = DockStyle.Fill;
            dayEvents17.FlowDirection = FlowDirection.TopDown;
            dayEvents17.Location = new Point(3, 20);
            dayEvents17.Margin = new Padding(0);
            dayEvents17.Name = "dayEvents17";
            dayEvents17.Size = new Size(162, 58);
            dayEvents17.TabIndex = 0;
            dayEvents17.WrapContents = false;
            // 
            // eventChip17_0
            // 
            eventChip17_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip17_0.BorderColor = Color.White;
            eventChip17_0.BorderRadius = 5;
            eventChip17_0.Cursor = Cursors.Hand;
            eventChip17_0.FlatStyle = FlatStyle.Flat;
            eventChip17_0.Font = new Font("Segoe UI", 7F);
            eventChip17_0.ForeColor = Color.White;
            eventChip17_0.HoverColor = Color.Empty;
            eventChip17_0.Location = new Point(0, 1);
            eventChip17_0.Margin = new Padding(0, 1, 0, 1);
            eventChip17_0.Name = "eventChip17_0";
            eventChip17_0.PressedColor = Color.Empty;
            eventChip17_0.Size = new Size(145, 16);
            eventChip17_0.TabIndex = 0;
            eventChip17_0.Text = "Event title";
            eventChip17_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip17_0.UseVisualStyleBackColor = false;
            eventChip17_0.Click += EventChip_Click;
            // 
            // eventChip17_1
            // 
            eventChip17_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip17_1.BorderColor = Color.White;
            eventChip17_1.BorderRadius = 5;
            eventChip17_1.Cursor = Cursors.Hand;
            eventChip17_1.FlatStyle = FlatStyle.Flat;
            eventChip17_1.Font = new Font("Segoe UI", 7F);
            eventChip17_1.ForeColor = Color.White;
            eventChip17_1.HoverColor = Color.Empty;
            eventChip17_1.Location = new Point(0, 19);
            eventChip17_1.Margin = new Padding(0, 1, 0, 1);
            eventChip17_1.Name = "eventChip17_1";
            eventChip17_1.PressedColor = Color.Empty;
            eventChip17_1.Size = new Size(145, 16);
            eventChip17_1.TabIndex = 1;
            eventChip17_1.Text = "Another event";
            eventChip17_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip17_1.UseVisualStyleBackColor = false;
            eventChip17_1.Click += EventChip_Click;
            // 
            // moreEvents17
            // 
            moreEvents17.Cursor = Cursors.Hand;
            moreEvents17.Font = new Font("Segoe UI", 7F);
            moreEvents17.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents17.Location = new Point(3, 36);
            moreEvents17.Name = "moreEvents17";
            moreEvents17.Size = new Size(100, 15);
            moreEvents17.TabIndex = 2;
            moreEvents17.Text = "+1 more";
            moreEvents17.Click += DayCell_Click;
            // 
            // dayNumber17
            // 
            dayNumber17.BackColor = Color.Transparent;
            dayNumber17.Cursor = Cursors.Hand;
            dayNumber17.Dock = DockStyle.Top;
            dayNumber17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber17.ForeColor = Color.White;
            dayNumber17.Location = new Point(3, 3);
            dayNumber17.Name = "dayNumber17";
            dayNumber17.Size = new Size(162, 17);
            dayNumber17.TabIndex = 1;
            dayNumber17.Text = "14";
            dayNumber17.Click += DayCell_Click;
            // 
            // dayCell18
            // 
            dayCell18.BackColor = Color.FromArgb(22, 33, 62);
            dayCell18.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell18.BorderWidth = 1;
            dayCell18.Controls.Add(dayEvents18);
            dayCell18.Controls.Add(dayNumber18);
            dayCell18.CornerRadius = 5;
            dayCell18.Cursor = Cursors.Hand;
            dayCell18.Dock = DockStyle.Fill;
            dayCell18.Location = new Point(681, 192);
            dayCell18.Margin = new Padding(1);
            dayCell18.Name = "dayCell18";
            dayCell18.Padding = new Padding(3);
            dayCell18.Size = new Size(168, 81);
            dayCell18.TabIndex = 25;
            dayCell18.Click += DayCell_Click;
            // 
            // dayEvents18
            // 
            dayEvents18.BackColor = Color.Transparent;
            dayEvents18.Controls.Add(eventChip18_0);
            dayEvents18.Controls.Add(eventChip18_1);
            dayEvents18.Controls.Add(moreEvents18);
            dayEvents18.Dock = DockStyle.Fill;
            dayEvents18.FlowDirection = FlowDirection.TopDown;
            dayEvents18.Location = new Point(3, 20);
            dayEvents18.Margin = new Padding(0);
            dayEvents18.Name = "dayEvents18";
            dayEvents18.Size = new Size(162, 58);
            dayEvents18.TabIndex = 0;
            dayEvents18.WrapContents = false;
            // 
            // eventChip18_0
            // 
            eventChip18_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip18_0.BorderColor = Color.White;
            eventChip18_0.BorderRadius = 5;
            eventChip18_0.Cursor = Cursors.Hand;
            eventChip18_0.FlatStyle = FlatStyle.Flat;
            eventChip18_0.Font = new Font("Segoe UI", 7F);
            eventChip18_0.ForeColor = Color.White;
            eventChip18_0.HoverColor = Color.Empty;
            eventChip18_0.Location = new Point(0, 1);
            eventChip18_0.Margin = new Padding(0, 1, 0, 1);
            eventChip18_0.Name = "eventChip18_0";
            eventChip18_0.PressedColor = Color.Empty;
            eventChip18_0.Size = new Size(145, 16);
            eventChip18_0.TabIndex = 0;
            eventChip18_0.Text = "Event title";
            eventChip18_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip18_0.UseVisualStyleBackColor = false;
            eventChip18_0.Click += EventChip_Click;
            // 
            // eventChip18_1
            // 
            eventChip18_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip18_1.BorderColor = Color.White;
            eventChip18_1.BorderRadius = 5;
            eventChip18_1.Cursor = Cursors.Hand;
            eventChip18_1.FlatStyle = FlatStyle.Flat;
            eventChip18_1.Font = new Font("Segoe UI", 7F);
            eventChip18_1.ForeColor = Color.White;
            eventChip18_1.HoverColor = Color.Empty;
            eventChip18_1.Location = new Point(0, 19);
            eventChip18_1.Margin = new Padding(0, 1, 0, 1);
            eventChip18_1.Name = "eventChip18_1";
            eventChip18_1.PressedColor = Color.Empty;
            eventChip18_1.Size = new Size(145, 16);
            eventChip18_1.TabIndex = 1;
            eventChip18_1.Text = "Another event";
            eventChip18_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip18_1.UseVisualStyleBackColor = false;
            eventChip18_1.Click += EventChip_Click;
            // 
            // moreEvents18
            // 
            moreEvents18.Cursor = Cursors.Hand;
            moreEvents18.Font = new Font("Segoe UI", 7F);
            moreEvents18.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents18.Location = new Point(3, 36);
            moreEvents18.Name = "moreEvents18";
            moreEvents18.Size = new Size(100, 15);
            moreEvents18.TabIndex = 2;
            moreEvents18.Text = "+1 more";
            moreEvents18.Click += DayCell_Click;
            // 
            // dayNumber18
            // 
            dayNumber18.BackColor = Color.Transparent;
            dayNumber18.Cursor = Cursors.Hand;
            dayNumber18.Dock = DockStyle.Top;
            dayNumber18.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber18.ForeColor = Color.White;
            dayNumber18.Location = new Point(3, 3);
            dayNumber18.Name = "dayNumber18";
            dayNumber18.Size = new Size(162, 17);
            dayNumber18.TabIndex = 1;
            dayNumber18.Text = "15";
            dayNumber18.Click += DayCell_Click;
            // 
            // dayCell19
            // 
            dayCell19.BackColor = Color.FromArgb(22, 33, 62);
            dayCell19.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell19.BorderWidth = 1;
            dayCell19.Controls.Add(dayEvents19);
            dayCell19.Controls.Add(dayNumber19);
            dayCell19.CornerRadius = 5;
            dayCell19.Cursor = Cursors.Hand;
            dayCell19.Dock = DockStyle.Fill;
            dayCell19.Location = new Point(851, 192);
            dayCell19.Margin = new Padding(1);
            dayCell19.Name = "dayCell19";
            dayCell19.Padding = new Padding(3);
            dayCell19.Size = new Size(168, 81);
            dayCell19.TabIndex = 26;
            dayCell19.Click += DayCell_Click;
            // 
            // dayEvents19
            // 
            dayEvents19.BackColor = Color.Transparent;
            dayEvents19.Controls.Add(eventChip19_0);
            dayEvents19.Controls.Add(eventChip19_1);
            dayEvents19.Controls.Add(moreEvents19);
            dayEvents19.Dock = DockStyle.Fill;
            dayEvents19.FlowDirection = FlowDirection.TopDown;
            dayEvents19.Location = new Point(3, 20);
            dayEvents19.Margin = new Padding(0);
            dayEvents19.Name = "dayEvents19";
            dayEvents19.Size = new Size(162, 58);
            dayEvents19.TabIndex = 0;
            dayEvents19.WrapContents = false;
            // 
            // eventChip19_0
            // 
            eventChip19_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip19_0.BorderColor = Color.White;
            eventChip19_0.BorderRadius = 5;
            eventChip19_0.Cursor = Cursors.Hand;
            eventChip19_0.FlatStyle = FlatStyle.Flat;
            eventChip19_0.Font = new Font("Segoe UI", 7F);
            eventChip19_0.ForeColor = Color.White;
            eventChip19_0.HoverColor = Color.Empty;
            eventChip19_0.Location = new Point(0, 1);
            eventChip19_0.Margin = new Padding(0, 1, 0, 1);
            eventChip19_0.Name = "eventChip19_0";
            eventChip19_0.PressedColor = Color.Empty;
            eventChip19_0.Size = new Size(145, 16);
            eventChip19_0.TabIndex = 0;
            eventChip19_0.Text = "Event title";
            eventChip19_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip19_0.UseVisualStyleBackColor = false;
            eventChip19_0.Click += EventChip_Click;
            // 
            // eventChip19_1
            // 
            eventChip19_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip19_1.BorderColor = Color.White;
            eventChip19_1.BorderRadius = 5;
            eventChip19_1.Cursor = Cursors.Hand;
            eventChip19_1.FlatStyle = FlatStyle.Flat;
            eventChip19_1.Font = new Font("Segoe UI", 7F);
            eventChip19_1.ForeColor = Color.White;
            eventChip19_1.HoverColor = Color.Empty;
            eventChip19_1.Location = new Point(0, 19);
            eventChip19_1.Margin = new Padding(0, 1, 0, 1);
            eventChip19_1.Name = "eventChip19_1";
            eventChip19_1.PressedColor = Color.Empty;
            eventChip19_1.Size = new Size(145, 16);
            eventChip19_1.TabIndex = 1;
            eventChip19_1.Text = "Another event";
            eventChip19_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip19_1.UseVisualStyleBackColor = false;
            eventChip19_1.Click += EventChip_Click;
            // 
            // moreEvents19
            // 
            moreEvents19.Cursor = Cursors.Hand;
            moreEvents19.Font = new Font("Segoe UI", 7F);
            moreEvents19.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents19.Location = new Point(3, 36);
            moreEvents19.Name = "moreEvents19";
            moreEvents19.Size = new Size(100, 15);
            moreEvents19.TabIndex = 2;
            moreEvents19.Text = "+1 more";
            moreEvents19.Click += DayCell_Click;
            // 
            // dayNumber19
            // 
            dayNumber19.BackColor = Color.Transparent;
            dayNumber19.Cursor = Cursors.Hand;
            dayNumber19.Dock = DockStyle.Top;
            dayNumber19.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber19.ForeColor = Color.White;
            dayNumber19.Location = new Point(3, 3);
            dayNumber19.Name = "dayNumber19";
            dayNumber19.Size = new Size(162, 17);
            dayNumber19.TabIndex = 1;
            dayNumber19.Text = "16";
            dayNumber19.Click += DayCell_Click;
            // 
            // dayCell20
            // 
            dayCell20.BackColor = Color.FromArgb(18, 23, 45);
            dayCell20.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell20.BorderWidth = 1;
            dayCell20.Controls.Add(dayEvents20);
            dayCell20.Controls.Add(dayNumber20);
            dayCell20.CornerRadius = 5;
            dayCell20.Cursor = Cursors.Hand;
            dayCell20.Dock = DockStyle.Fill;
            dayCell20.Location = new Point(1021, 192);
            dayCell20.Margin = new Padding(1);
            dayCell20.Name = "dayCell20";
            dayCell20.Padding = new Padding(3);
            dayCell20.Size = new Size(170, 81);
            dayCell20.TabIndex = 27;
            dayCell20.Click += DayCell_Click;
            // 
            // dayEvents20
            // 
            dayEvents20.BackColor = Color.Transparent;
            dayEvents20.Controls.Add(eventChip20_0);
            dayEvents20.Controls.Add(eventChip20_1);
            dayEvents20.Controls.Add(moreEvents20);
            dayEvents20.Dock = DockStyle.Fill;
            dayEvents20.FlowDirection = FlowDirection.TopDown;
            dayEvents20.Location = new Point(3, 20);
            dayEvents20.Margin = new Padding(0);
            dayEvents20.Name = "dayEvents20";
            dayEvents20.Size = new Size(164, 58);
            dayEvents20.TabIndex = 0;
            dayEvents20.WrapContents = false;
            // 
            // eventChip20_0
            // 
            eventChip20_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip20_0.BorderColor = Color.White;
            eventChip20_0.BorderRadius = 5;
            eventChip20_0.Cursor = Cursors.Hand;
            eventChip20_0.FlatStyle = FlatStyle.Flat;
            eventChip20_0.Font = new Font("Segoe UI", 7F);
            eventChip20_0.ForeColor = Color.White;
            eventChip20_0.HoverColor = Color.Empty;
            eventChip20_0.Location = new Point(0, 1);
            eventChip20_0.Margin = new Padding(0, 1, 0, 1);
            eventChip20_0.Name = "eventChip20_0";
            eventChip20_0.PressedColor = Color.Empty;
            eventChip20_0.Size = new Size(145, 16);
            eventChip20_0.TabIndex = 0;
            eventChip20_0.Text = "Event title";
            eventChip20_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip20_0.UseVisualStyleBackColor = false;
            eventChip20_0.Click += EventChip_Click;
            // 
            // eventChip20_1
            // 
            eventChip20_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip20_1.BorderColor = Color.White;
            eventChip20_1.BorderRadius = 5;
            eventChip20_1.Cursor = Cursors.Hand;
            eventChip20_1.FlatStyle = FlatStyle.Flat;
            eventChip20_1.Font = new Font("Segoe UI", 7F);
            eventChip20_1.ForeColor = Color.White;
            eventChip20_1.HoverColor = Color.Empty;
            eventChip20_1.Location = new Point(0, 19);
            eventChip20_1.Margin = new Padding(0, 1, 0, 1);
            eventChip20_1.Name = "eventChip20_1";
            eventChip20_1.PressedColor = Color.Empty;
            eventChip20_1.Size = new Size(145, 16);
            eventChip20_1.TabIndex = 1;
            eventChip20_1.Text = "Another event";
            eventChip20_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip20_1.UseVisualStyleBackColor = false;
            eventChip20_1.Click += EventChip_Click;
            // 
            // moreEvents20
            // 
            moreEvents20.Cursor = Cursors.Hand;
            moreEvents20.Font = new Font("Segoe UI", 7F);
            moreEvents20.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents20.Location = new Point(3, 36);
            moreEvents20.Name = "moreEvents20";
            moreEvents20.Size = new Size(100, 15);
            moreEvents20.TabIndex = 2;
            moreEvents20.Text = "+1 more";
            moreEvents20.Click += DayCell_Click;
            // 
            // dayNumber20
            // 
            dayNumber20.BackColor = Color.Transparent;
            dayNumber20.Cursor = Cursors.Hand;
            dayNumber20.Dock = DockStyle.Top;
            dayNumber20.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber20.ForeColor = Color.White;
            dayNumber20.Location = new Point(3, 3);
            dayNumber20.Name = "dayNumber20";
            dayNumber20.Size = new Size(164, 17);
            dayNumber20.TabIndex = 1;
            dayNumber20.Text = "17";
            dayNumber20.Click += DayCell_Click;
            // 
            // dayCell21
            // 
            dayCell21.BackColor = Color.FromArgb(18, 23, 45);
            dayCell21.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell21.BorderWidth = 1;
            dayCell21.Controls.Add(dayEvents21);
            dayCell21.Controls.Add(dayNumber21);
            dayCell21.CornerRadius = 5;
            dayCell21.Cursor = Cursors.Hand;
            dayCell21.Dock = DockStyle.Fill;
            dayCell21.Location = new Point(1, 275);
            dayCell21.Margin = new Padding(1);
            dayCell21.Name = "dayCell21";
            dayCell21.Padding = new Padding(3);
            dayCell21.Size = new Size(168, 81);
            dayCell21.TabIndex = 28;
            dayCell21.Click += DayCell_Click;
            // 
            // dayEvents21
            // 
            dayEvents21.BackColor = Color.Transparent;
            dayEvents21.Controls.Add(eventChip21_0);
            dayEvents21.Controls.Add(eventChip21_1);
            dayEvents21.Controls.Add(moreEvents21);
            dayEvents21.Dock = DockStyle.Fill;
            dayEvents21.FlowDirection = FlowDirection.TopDown;
            dayEvents21.Location = new Point(3, 20);
            dayEvents21.Margin = new Padding(0);
            dayEvents21.Name = "dayEvents21";
            dayEvents21.Size = new Size(162, 58);
            dayEvents21.TabIndex = 0;
            dayEvents21.WrapContents = false;
            // 
            // eventChip21_0
            // 
            eventChip21_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip21_0.BorderColor = Color.White;
            eventChip21_0.BorderRadius = 5;
            eventChip21_0.Cursor = Cursors.Hand;
            eventChip21_0.FlatStyle = FlatStyle.Flat;
            eventChip21_0.Font = new Font("Segoe UI", 7F);
            eventChip21_0.ForeColor = Color.White;
            eventChip21_0.HoverColor = Color.Empty;
            eventChip21_0.Location = new Point(0, 1);
            eventChip21_0.Margin = new Padding(0, 1, 0, 1);
            eventChip21_0.Name = "eventChip21_0";
            eventChip21_0.PressedColor = Color.Empty;
            eventChip21_0.Size = new Size(145, 16);
            eventChip21_0.TabIndex = 0;
            eventChip21_0.Text = "Event title";
            eventChip21_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip21_0.UseVisualStyleBackColor = false;
            eventChip21_0.Click += EventChip_Click;
            // 
            // eventChip21_1
            // 
            eventChip21_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip21_1.BorderColor = Color.White;
            eventChip21_1.BorderRadius = 5;
            eventChip21_1.Cursor = Cursors.Hand;
            eventChip21_1.FlatStyle = FlatStyle.Flat;
            eventChip21_1.Font = new Font("Segoe UI", 7F);
            eventChip21_1.ForeColor = Color.White;
            eventChip21_1.HoverColor = Color.Empty;
            eventChip21_1.Location = new Point(0, 19);
            eventChip21_1.Margin = new Padding(0, 1, 0, 1);
            eventChip21_1.Name = "eventChip21_1";
            eventChip21_1.PressedColor = Color.Empty;
            eventChip21_1.Size = new Size(145, 16);
            eventChip21_1.TabIndex = 1;
            eventChip21_1.Text = "Another event";
            eventChip21_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip21_1.UseVisualStyleBackColor = false;
            eventChip21_1.Click += EventChip_Click;
            // 
            // moreEvents21
            // 
            moreEvents21.Cursor = Cursors.Hand;
            moreEvents21.Font = new Font("Segoe UI", 7F);
            moreEvents21.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents21.Location = new Point(3, 36);
            moreEvents21.Name = "moreEvents21";
            moreEvents21.Size = new Size(100, 15);
            moreEvents21.TabIndex = 2;
            moreEvents21.Text = "+1 more";
            moreEvents21.Click += DayCell_Click;
            // 
            // dayNumber21
            // 
            dayNumber21.BackColor = Color.Transparent;
            dayNumber21.Cursor = Cursors.Hand;
            dayNumber21.Dock = DockStyle.Top;
            dayNumber21.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber21.ForeColor = Color.White;
            dayNumber21.Location = new Point(3, 3);
            dayNumber21.Name = "dayNumber21";
            dayNumber21.Size = new Size(162, 17);
            dayNumber21.TabIndex = 1;
            dayNumber21.Text = "18";
            dayNumber21.Click += DayCell_Click;
            // 
            // dayCell22
            // 
            dayCell22.BackColor = Color.FromArgb(22, 33, 62);
            dayCell22.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell22.BorderWidth = 1;
            dayCell22.Controls.Add(dayEvents22);
            dayCell22.Controls.Add(dayNumber22);
            dayCell22.CornerRadius = 5;
            dayCell22.Cursor = Cursors.Hand;
            dayCell22.Dock = DockStyle.Fill;
            dayCell22.Location = new Point(171, 275);
            dayCell22.Margin = new Padding(1);
            dayCell22.Name = "dayCell22";
            dayCell22.Padding = new Padding(3);
            dayCell22.Size = new Size(168, 81);
            dayCell22.TabIndex = 29;
            dayCell22.Click += DayCell_Click;
            // 
            // dayEvents22
            // 
            dayEvents22.BackColor = Color.Transparent;
            dayEvents22.Controls.Add(eventChip22_0);
            dayEvents22.Controls.Add(eventChip22_1);
            dayEvents22.Controls.Add(moreEvents22);
            dayEvents22.Dock = DockStyle.Fill;
            dayEvents22.FlowDirection = FlowDirection.TopDown;
            dayEvents22.Location = new Point(3, 20);
            dayEvents22.Margin = new Padding(0);
            dayEvents22.Name = "dayEvents22";
            dayEvents22.Size = new Size(162, 58);
            dayEvents22.TabIndex = 0;
            dayEvents22.WrapContents = false;
            // 
            // eventChip22_0
            // 
            eventChip22_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip22_0.BorderColor = Color.White;
            eventChip22_0.BorderRadius = 5;
            eventChip22_0.Cursor = Cursors.Hand;
            eventChip22_0.FlatStyle = FlatStyle.Flat;
            eventChip22_0.Font = new Font("Segoe UI", 7F);
            eventChip22_0.ForeColor = Color.White;
            eventChip22_0.HoverColor = Color.Empty;
            eventChip22_0.Location = new Point(0, 1);
            eventChip22_0.Margin = new Padding(0, 1, 0, 1);
            eventChip22_0.Name = "eventChip22_0";
            eventChip22_0.PressedColor = Color.Empty;
            eventChip22_0.Size = new Size(145, 16);
            eventChip22_0.TabIndex = 0;
            eventChip22_0.Text = "Event title";
            eventChip22_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip22_0.UseVisualStyleBackColor = false;
            eventChip22_0.Click += EventChip_Click;
            // 
            // eventChip22_1
            // 
            eventChip22_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip22_1.BorderColor = Color.White;
            eventChip22_1.BorderRadius = 5;
            eventChip22_1.Cursor = Cursors.Hand;
            eventChip22_1.FlatStyle = FlatStyle.Flat;
            eventChip22_1.Font = new Font("Segoe UI", 7F);
            eventChip22_1.ForeColor = Color.White;
            eventChip22_1.HoverColor = Color.Empty;
            eventChip22_1.Location = new Point(0, 19);
            eventChip22_1.Margin = new Padding(0, 1, 0, 1);
            eventChip22_1.Name = "eventChip22_1";
            eventChip22_1.PressedColor = Color.Empty;
            eventChip22_1.Size = new Size(145, 16);
            eventChip22_1.TabIndex = 1;
            eventChip22_1.Text = "Another event";
            eventChip22_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip22_1.UseVisualStyleBackColor = false;
            eventChip22_1.Click += EventChip_Click;
            // 
            // moreEvents22
            // 
            moreEvents22.Cursor = Cursors.Hand;
            moreEvents22.Font = new Font("Segoe UI", 7F);
            moreEvents22.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents22.Location = new Point(3, 36);
            moreEvents22.Name = "moreEvents22";
            moreEvents22.Size = new Size(100, 15);
            moreEvents22.TabIndex = 2;
            moreEvents22.Text = "+1 more";
            moreEvents22.Click += DayCell_Click;
            // 
            // dayNumber22
            // 
            dayNumber22.BackColor = Color.Transparent;
            dayNumber22.Cursor = Cursors.Hand;
            dayNumber22.Dock = DockStyle.Top;
            dayNumber22.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber22.ForeColor = Color.White;
            dayNumber22.Location = new Point(3, 3);
            dayNumber22.Name = "dayNumber22";
            dayNumber22.Size = new Size(162, 17);
            dayNumber22.TabIndex = 1;
            dayNumber22.Text = "19";
            dayNumber22.Click += DayCell_Click;
            // 
            // dayCell23
            // 
            dayCell23.BackColor = Color.FromArgb(22, 33, 62);
            dayCell23.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell23.BorderWidth = 1;
            dayCell23.Controls.Add(dayEvents23);
            dayCell23.Controls.Add(dayNumber23);
            dayCell23.CornerRadius = 5;
            dayCell23.Cursor = Cursors.Hand;
            dayCell23.Dock = DockStyle.Fill;
            dayCell23.Location = new Point(341, 275);
            dayCell23.Margin = new Padding(1);
            dayCell23.Name = "dayCell23";
            dayCell23.Padding = new Padding(3);
            dayCell23.Size = new Size(168, 81);
            dayCell23.TabIndex = 30;
            dayCell23.Click += DayCell_Click;
            // 
            // dayEvents23
            // 
            dayEvents23.BackColor = Color.Transparent;
            dayEvents23.Controls.Add(eventChip23_0);
            dayEvents23.Controls.Add(eventChip23_1);
            dayEvents23.Controls.Add(moreEvents23);
            dayEvents23.Dock = DockStyle.Fill;
            dayEvents23.FlowDirection = FlowDirection.TopDown;
            dayEvents23.Location = new Point(3, 20);
            dayEvents23.Margin = new Padding(0);
            dayEvents23.Name = "dayEvents23";
            dayEvents23.Size = new Size(162, 58);
            dayEvents23.TabIndex = 0;
            dayEvents23.WrapContents = false;
            // 
            // eventChip23_0
            // 
            eventChip23_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip23_0.BorderColor = Color.White;
            eventChip23_0.BorderRadius = 5;
            eventChip23_0.Cursor = Cursors.Hand;
            eventChip23_0.FlatStyle = FlatStyle.Flat;
            eventChip23_0.Font = new Font("Segoe UI", 7F);
            eventChip23_0.ForeColor = Color.White;
            eventChip23_0.HoverColor = Color.Empty;
            eventChip23_0.Location = new Point(0, 1);
            eventChip23_0.Margin = new Padding(0, 1, 0, 1);
            eventChip23_0.Name = "eventChip23_0";
            eventChip23_0.PressedColor = Color.Empty;
            eventChip23_0.Size = new Size(145, 16);
            eventChip23_0.TabIndex = 0;
            eventChip23_0.Text = "Event title";
            eventChip23_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip23_0.UseVisualStyleBackColor = false;
            eventChip23_0.Click += EventChip_Click;
            // 
            // eventChip23_1
            // 
            eventChip23_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip23_1.BorderColor = Color.White;
            eventChip23_1.BorderRadius = 5;
            eventChip23_1.Cursor = Cursors.Hand;
            eventChip23_1.FlatStyle = FlatStyle.Flat;
            eventChip23_1.Font = new Font("Segoe UI", 7F);
            eventChip23_1.ForeColor = Color.White;
            eventChip23_1.HoverColor = Color.Empty;
            eventChip23_1.Location = new Point(0, 19);
            eventChip23_1.Margin = new Padding(0, 1, 0, 1);
            eventChip23_1.Name = "eventChip23_1";
            eventChip23_1.PressedColor = Color.Empty;
            eventChip23_1.Size = new Size(145, 16);
            eventChip23_1.TabIndex = 1;
            eventChip23_1.Text = "Another event";
            eventChip23_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip23_1.UseVisualStyleBackColor = false;
            eventChip23_1.Click += EventChip_Click;
            // 
            // moreEvents23
            // 
            moreEvents23.Cursor = Cursors.Hand;
            moreEvents23.Font = new Font("Segoe UI", 7F);
            moreEvents23.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents23.Location = new Point(3, 36);
            moreEvents23.Name = "moreEvents23";
            moreEvents23.Size = new Size(100, 15);
            moreEvents23.TabIndex = 2;
            moreEvents23.Text = "+1 more";
            moreEvents23.Click += DayCell_Click;
            // 
            // dayNumber23
            // 
            dayNumber23.BackColor = Color.Transparent;
            dayNumber23.Cursor = Cursors.Hand;
            dayNumber23.Dock = DockStyle.Top;
            dayNumber23.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber23.ForeColor = Color.White;
            dayNumber23.Location = new Point(3, 3);
            dayNumber23.Name = "dayNumber23";
            dayNumber23.Size = new Size(162, 17);
            dayNumber23.TabIndex = 1;
            dayNumber23.Text = "20";
            dayNumber23.Click += DayCell_Click;
            // 
            // dayCell24
            // 
            dayCell24.BackColor = Color.FromArgb(22, 33, 62);
            dayCell24.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell24.BorderWidth = 1;
            dayCell24.Controls.Add(dayEvents24);
            dayCell24.Controls.Add(dayNumber24);
            dayCell24.CornerRadius = 5;
            dayCell24.Cursor = Cursors.Hand;
            dayCell24.Dock = DockStyle.Fill;
            dayCell24.Location = new Point(511, 275);
            dayCell24.Margin = new Padding(1);
            dayCell24.Name = "dayCell24";
            dayCell24.Padding = new Padding(3);
            dayCell24.Size = new Size(168, 81);
            dayCell24.TabIndex = 31;
            dayCell24.Click += DayCell_Click;
            // 
            // dayEvents24
            // 
            dayEvents24.BackColor = Color.Transparent;
            dayEvents24.Controls.Add(eventChip24_0);
            dayEvents24.Controls.Add(eventChip24_1);
            dayEvents24.Controls.Add(moreEvents24);
            dayEvents24.Dock = DockStyle.Fill;
            dayEvents24.FlowDirection = FlowDirection.TopDown;
            dayEvents24.Location = new Point(3, 20);
            dayEvents24.Margin = new Padding(0);
            dayEvents24.Name = "dayEvents24";
            dayEvents24.Size = new Size(162, 58);
            dayEvents24.TabIndex = 0;
            dayEvents24.WrapContents = false;
            // 
            // eventChip24_0
            // 
            eventChip24_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip24_0.BorderColor = Color.White;
            eventChip24_0.BorderRadius = 5;
            eventChip24_0.Cursor = Cursors.Hand;
            eventChip24_0.FlatStyle = FlatStyle.Flat;
            eventChip24_0.Font = new Font("Segoe UI", 7F);
            eventChip24_0.ForeColor = Color.White;
            eventChip24_0.HoverColor = Color.Empty;
            eventChip24_0.Location = new Point(0, 1);
            eventChip24_0.Margin = new Padding(0, 1, 0, 1);
            eventChip24_0.Name = "eventChip24_0";
            eventChip24_0.PressedColor = Color.Empty;
            eventChip24_0.Size = new Size(145, 16);
            eventChip24_0.TabIndex = 0;
            eventChip24_0.Text = "Event title";
            eventChip24_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip24_0.UseVisualStyleBackColor = false;
            eventChip24_0.Click += EventChip_Click;
            // 
            // eventChip24_1
            // 
            eventChip24_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip24_1.BorderColor = Color.White;
            eventChip24_1.BorderRadius = 5;
            eventChip24_1.Cursor = Cursors.Hand;
            eventChip24_1.FlatStyle = FlatStyle.Flat;
            eventChip24_1.Font = new Font("Segoe UI", 7F);
            eventChip24_1.ForeColor = Color.White;
            eventChip24_1.HoverColor = Color.Empty;
            eventChip24_1.Location = new Point(0, 19);
            eventChip24_1.Margin = new Padding(0, 1, 0, 1);
            eventChip24_1.Name = "eventChip24_1";
            eventChip24_1.PressedColor = Color.Empty;
            eventChip24_1.Size = new Size(145, 16);
            eventChip24_1.TabIndex = 1;
            eventChip24_1.Text = "Another event";
            eventChip24_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip24_1.UseVisualStyleBackColor = false;
            eventChip24_1.Click += EventChip_Click;
            // 
            // moreEvents24
            // 
            moreEvents24.Cursor = Cursors.Hand;
            moreEvents24.Font = new Font("Segoe UI", 7F);
            moreEvents24.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents24.Location = new Point(3, 36);
            moreEvents24.Name = "moreEvents24";
            moreEvents24.Size = new Size(100, 15);
            moreEvents24.TabIndex = 2;
            moreEvents24.Text = "+1 more";
            moreEvents24.Click += DayCell_Click;
            // 
            // dayNumber24
            // 
            dayNumber24.BackColor = Color.Transparent;
            dayNumber24.Cursor = Cursors.Hand;
            dayNumber24.Dock = DockStyle.Top;
            dayNumber24.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber24.ForeColor = Color.White;
            dayNumber24.Location = new Point(3, 3);
            dayNumber24.Name = "dayNumber24";
            dayNumber24.Size = new Size(162, 17);
            dayNumber24.TabIndex = 1;
            dayNumber24.Text = "21";
            dayNumber24.Click += DayCell_Click;
            // 
            // dayCell25
            // 
            dayCell25.BackColor = Color.FromArgb(22, 33, 62);
            dayCell25.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell25.BorderWidth = 1;
            dayCell25.Controls.Add(dayEvents25);
            dayCell25.Controls.Add(dayNumber25);
            dayCell25.CornerRadius = 5;
            dayCell25.Cursor = Cursors.Hand;
            dayCell25.Dock = DockStyle.Fill;
            dayCell25.Location = new Point(681, 275);
            dayCell25.Margin = new Padding(1);
            dayCell25.Name = "dayCell25";
            dayCell25.Padding = new Padding(3);
            dayCell25.Size = new Size(168, 81);
            dayCell25.TabIndex = 32;
            dayCell25.Click += DayCell_Click;
            // 
            // dayEvents25
            // 
            dayEvents25.BackColor = Color.Transparent;
            dayEvents25.Controls.Add(eventChip25_0);
            dayEvents25.Controls.Add(eventChip25_1);
            dayEvents25.Controls.Add(moreEvents25);
            dayEvents25.Dock = DockStyle.Fill;
            dayEvents25.FlowDirection = FlowDirection.TopDown;
            dayEvents25.Location = new Point(3, 20);
            dayEvents25.Margin = new Padding(0);
            dayEvents25.Name = "dayEvents25";
            dayEvents25.Size = new Size(162, 58);
            dayEvents25.TabIndex = 0;
            dayEvents25.WrapContents = false;
            // 
            // eventChip25_0
            // 
            eventChip25_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip25_0.BorderColor = Color.White;
            eventChip25_0.BorderRadius = 5;
            eventChip25_0.Cursor = Cursors.Hand;
            eventChip25_0.FlatStyle = FlatStyle.Flat;
            eventChip25_0.Font = new Font("Segoe UI", 7F);
            eventChip25_0.ForeColor = Color.White;
            eventChip25_0.HoverColor = Color.Empty;
            eventChip25_0.Location = new Point(0, 1);
            eventChip25_0.Margin = new Padding(0, 1, 0, 1);
            eventChip25_0.Name = "eventChip25_0";
            eventChip25_0.PressedColor = Color.Empty;
            eventChip25_0.Size = new Size(145, 16);
            eventChip25_0.TabIndex = 0;
            eventChip25_0.Text = "Event title";
            eventChip25_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip25_0.UseVisualStyleBackColor = false;
            eventChip25_0.Click += EventChip_Click;
            // 
            // eventChip25_1
            // 
            eventChip25_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip25_1.BorderColor = Color.White;
            eventChip25_1.BorderRadius = 5;
            eventChip25_1.Cursor = Cursors.Hand;
            eventChip25_1.FlatStyle = FlatStyle.Flat;
            eventChip25_1.Font = new Font("Segoe UI", 7F);
            eventChip25_1.ForeColor = Color.White;
            eventChip25_1.HoverColor = Color.Empty;
            eventChip25_1.Location = new Point(0, 19);
            eventChip25_1.Margin = new Padding(0, 1, 0, 1);
            eventChip25_1.Name = "eventChip25_1";
            eventChip25_1.PressedColor = Color.Empty;
            eventChip25_1.Size = new Size(145, 16);
            eventChip25_1.TabIndex = 1;
            eventChip25_1.Text = "Another event";
            eventChip25_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip25_1.UseVisualStyleBackColor = false;
            eventChip25_1.Click += EventChip_Click;
            // 
            // moreEvents25
            // 
            moreEvents25.Cursor = Cursors.Hand;
            moreEvents25.Font = new Font("Segoe UI", 7F);
            moreEvents25.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents25.Location = new Point(3, 36);
            moreEvents25.Name = "moreEvents25";
            moreEvents25.Size = new Size(100, 15);
            moreEvents25.TabIndex = 2;
            moreEvents25.Text = "+1 more";
            moreEvents25.Click += DayCell_Click;
            // 
            // dayNumber25
            // 
            dayNumber25.BackColor = Color.Transparent;
            dayNumber25.Cursor = Cursors.Hand;
            dayNumber25.Dock = DockStyle.Top;
            dayNumber25.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber25.ForeColor = Color.White;
            dayNumber25.Location = new Point(3, 3);
            dayNumber25.Name = "dayNumber25";
            dayNumber25.Size = new Size(162, 17);
            dayNumber25.TabIndex = 1;
            dayNumber25.Text = "22";
            dayNumber25.Click += DayCell_Click;
            // 
            // dayCell26
            // 
            dayCell26.BackColor = Color.FromArgb(22, 33, 62);
            dayCell26.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell26.BorderWidth = 1;
            dayCell26.Controls.Add(dayEvents26);
            dayCell26.Controls.Add(dayNumber26);
            dayCell26.CornerRadius = 5;
            dayCell26.Cursor = Cursors.Hand;
            dayCell26.Dock = DockStyle.Fill;
            dayCell26.Location = new Point(851, 275);
            dayCell26.Margin = new Padding(1);
            dayCell26.Name = "dayCell26";
            dayCell26.Padding = new Padding(3);
            dayCell26.Size = new Size(168, 81);
            dayCell26.TabIndex = 33;
            dayCell26.Click += DayCell_Click;
            // 
            // dayEvents26
            // 
            dayEvents26.BackColor = Color.Transparent;
            dayEvents26.Controls.Add(eventChip26_0);
            dayEvents26.Controls.Add(eventChip26_1);
            dayEvents26.Controls.Add(moreEvents26);
            dayEvents26.Dock = DockStyle.Fill;
            dayEvents26.FlowDirection = FlowDirection.TopDown;
            dayEvents26.Location = new Point(3, 20);
            dayEvents26.Margin = new Padding(0);
            dayEvents26.Name = "dayEvents26";
            dayEvents26.Size = new Size(162, 58);
            dayEvents26.TabIndex = 0;
            dayEvents26.WrapContents = false;
            // 
            // eventChip26_0
            // 
            eventChip26_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip26_0.BorderColor = Color.White;
            eventChip26_0.BorderRadius = 5;
            eventChip26_0.Cursor = Cursors.Hand;
            eventChip26_0.FlatStyle = FlatStyle.Flat;
            eventChip26_0.Font = new Font("Segoe UI", 7F);
            eventChip26_0.ForeColor = Color.White;
            eventChip26_0.HoverColor = Color.Empty;
            eventChip26_0.Location = new Point(0, 1);
            eventChip26_0.Margin = new Padding(0, 1, 0, 1);
            eventChip26_0.Name = "eventChip26_0";
            eventChip26_0.PressedColor = Color.Empty;
            eventChip26_0.Size = new Size(145, 16);
            eventChip26_0.TabIndex = 0;
            eventChip26_0.Text = "Event title";
            eventChip26_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip26_0.UseVisualStyleBackColor = false;
            eventChip26_0.Click += EventChip_Click;
            // 
            // eventChip26_1
            // 
            eventChip26_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip26_1.BorderColor = Color.White;
            eventChip26_1.BorderRadius = 5;
            eventChip26_1.Cursor = Cursors.Hand;
            eventChip26_1.FlatStyle = FlatStyle.Flat;
            eventChip26_1.Font = new Font("Segoe UI", 7F);
            eventChip26_1.ForeColor = Color.White;
            eventChip26_1.HoverColor = Color.Empty;
            eventChip26_1.Location = new Point(0, 19);
            eventChip26_1.Margin = new Padding(0, 1, 0, 1);
            eventChip26_1.Name = "eventChip26_1";
            eventChip26_1.PressedColor = Color.Empty;
            eventChip26_1.Size = new Size(145, 16);
            eventChip26_1.TabIndex = 1;
            eventChip26_1.Text = "Another event";
            eventChip26_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip26_1.UseVisualStyleBackColor = false;
            eventChip26_1.Click += EventChip_Click;
            // 
            // moreEvents26
            // 
            moreEvents26.Cursor = Cursors.Hand;
            moreEvents26.Font = new Font("Segoe UI", 7F);
            moreEvents26.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents26.Location = new Point(3, 36);
            moreEvents26.Name = "moreEvents26";
            moreEvents26.Size = new Size(100, 15);
            moreEvents26.TabIndex = 2;
            moreEvents26.Text = "+1 more";
            moreEvents26.Click += DayCell_Click;
            // 
            // dayNumber26
            // 
            dayNumber26.BackColor = Color.Transparent;
            dayNumber26.Cursor = Cursors.Hand;
            dayNumber26.Dock = DockStyle.Top;
            dayNumber26.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber26.ForeColor = Color.White;
            dayNumber26.Location = new Point(3, 3);
            dayNumber26.Name = "dayNumber26";
            dayNumber26.Size = new Size(162, 17);
            dayNumber26.TabIndex = 1;
            dayNumber26.Text = "23";
            dayNumber26.Click += DayCell_Click;
            // 
            // dayCell27
            // 
            dayCell27.BackColor = Color.FromArgb(18, 23, 45);
            dayCell27.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell27.BorderWidth = 1;
            dayCell27.Controls.Add(dayEvents27);
            dayCell27.Controls.Add(dayNumber27);
            dayCell27.CornerRadius = 5;
            dayCell27.Cursor = Cursors.Hand;
            dayCell27.Dock = DockStyle.Fill;
            dayCell27.Location = new Point(1021, 275);
            dayCell27.Margin = new Padding(1);
            dayCell27.Name = "dayCell27";
            dayCell27.Padding = new Padding(3);
            dayCell27.Size = new Size(170, 81);
            dayCell27.TabIndex = 34;
            dayCell27.Click += DayCell_Click;
            // 
            // dayEvents27
            // 
            dayEvents27.BackColor = Color.Transparent;
            dayEvents27.Controls.Add(eventChip27_0);
            dayEvents27.Controls.Add(eventChip27_1);
            dayEvents27.Controls.Add(moreEvents27);
            dayEvents27.Dock = DockStyle.Fill;
            dayEvents27.FlowDirection = FlowDirection.TopDown;
            dayEvents27.Location = new Point(3, 20);
            dayEvents27.Margin = new Padding(0);
            dayEvents27.Name = "dayEvents27";
            dayEvents27.Size = new Size(164, 58);
            dayEvents27.TabIndex = 0;
            dayEvents27.WrapContents = false;
            // 
            // eventChip27_0
            // 
            eventChip27_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip27_0.BorderColor = Color.White;
            eventChip27_0.BorderRadius = 5;
            eventChip27_0.Cursor = Cursors.Hand;
            eventChip27_0.FlatStyle = FlatStyle.Flat;
            eventChip27_0.Font = new Font("Segoe UI", 7F);
            eventChip27_0.ForeColor = Color.White;
            eventChip27_0.HoverColor = Color.Empty;
            eventChip27_0.Location = new Point(0, 1);
            eventChip27_0.Margin = new Padding(0, 1, 0, 1);
            eventChip27_0.Name = "eventChip27_0";
            eventChip27_0.PressedColor = Color.Empty;
            eventChip27_0.Size = new Size(145, 16);
            eventChip27_0.TabIndex = 0;
            eventChip27_0.Text = "Event title";
            eventChip27_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip27_0.UseVisualStyleBackColor = false;
            eventChip27_0.Click += EventChip_Click;
            // 
            // eventChip27_1
            // 
            eventChip27_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip27_1.BorderColor = Color.White;
            eventChip27_1.BorderRadius = 5;
            eventChip27_1.Cursor = Cursors.Hand;
            eventChip27_1.FlatStyle = FlatStyle.Flat;
            eventChip27_1.Font = new Font("Segoe UI", 7F);
            eventChip27_1.ForeColor = Color.White;
            eventChip27_1.HoverColor = Color.Empty;
            eventChip27_1.Location = new Point(0, 19);
            eventChip27_1.Margin = new Padding(0, 1, 0, 1);
            eventChip27_1.Name = "eventChip27_1";
            eventChip27_1.PressedColor = Color.Empty;
            eventChip27_1.Size = new Size(145, 16);
            eventChip27_1.TabIndex = 1;
            eventChip27_1.Text = "Another event";
            eventChip27_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip27_1.UseVisualStyleBackColor = false;
            eventChip27_1.Click += EventChip_Click;
            // 
            // moreEvents27
            // 
            moreEvents27.Cursor = Cursors.Hand;
            moreEvents27.Font = new Font("Segoe UI", 7F);
            moreEvents27.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents27.Location = new Point(3, 36);
            moreEvents27.Name = "moreEvents27";
            moreEvents27.Size = new Size(100, 15);
            moreEvents27.TabIndex = 2;
            moreEvents27.Text = "+1 more";
            moreEvents27.Click += DayCell_Click;
            // 
            // dayNumber27
            // 
            dayNumber27.BackColor = Color.Transparent;
            dayNumber27.Cursor = Cursors.Hand;
            dayNumber27.Dock = DockStyle.Top;
            dayNumber27.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber27.ForeColor = Color.White;
            dayNumber27.Location = new Point(3, 3);
            dayNumber27.Name = "dayNumber27";
            dayNumber27.Size = new Size(164, 17);
            dayNumber27.TabIndex = 1;
            dayNumber27.Text = "24";
            dayNumber27.Click += DayCell_Click;
            // 
            // dayCell28
            // 
            dayCell28.BackColor = Color.FromArgb(18, 23, 45);
            dayCell28.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell28.BorderWidth = 1;
            dayCell28.Controls.Add(dayEvents28);
            dayCell28.Controls.Add(dayNumber28);
            dayCell28.CornerRadius = 5;
            dayCell28.Cursor = Cursors.Hand;
            dayCell28.Dock = DockStyle.Fill;
            dayCell28.Location = new Point(1, 358);
            dayCell28.Margin = new Padding(1);
            dayCell28.Name = "dayCell28";
            dayCell28.Padding = new Padding(3);
            dayCell28.Size = new Size(168, 81);
            dayCell28.TabIndex = 35;
            dayCell28.Click += DayCell_Click;
            // 
            // dayEvents28
            // 
            dayEvents28.BackColor = Color.Transparent;
            dayEvents28.Controls.Add(eventChip28_0);
            dayEvents28.Controls.Add(eventChip28_1);
            dayEvents28.Controls.Add(moreEvents28);
            dayEvents28.Dock = DockStyle.Fill;
            dayEvents28.FlowDirection = FlowDirection.TopDown;
            dayEvents28.Location = new Point(3, 20);
            dayEvents28.Margin = new Padding(0);
            dayEvents28.Name = "dayEvents28";
            dayEvents28.Size = new Size(162, 58);
            dayEvents28.TabIndex = 0;
            dayEvents28.WrapContents = false;
            // 
            // eventChip28_0
            // 
            eventChip28_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip28_0.BorderColor = Color.White;
            eventChip28_0.BorderRadius = 5;
            eventChip28_0.Cursor = Cursors.Hand;
            eventChip28_0.FlatStyle = FlatStyle.Flat;
            eventChip28_0.Font = new Font("Segoe UI", 7F);
            eventChip28_0.ForeColor = Color.White;
            eventChip28_0.HoverColor = Color.Empty;
            eventChip28_0.Location = new Point(0, 1);
            eventChip28_0.Margin = new Padding(0, 1, 0, 1);
            eventChip28_0.Name = "eventChip28_0";
            eventChip28_0.PressedColor = Color.Empty;
            eventChip28_0.Size = new Size(145, 16);
            eventChip28_0.TabIndex = 0;
            eventChip28_0.Text = "Event title";
            eventChip28_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip28_0.UseVisualStyleBackColor = false;
            eventChip28_0.Click += EventChip_Click;
            // 
            // eventChip28_1
            // 
            eventChip28_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip28_1.BorderColor = Color.White;
            eventChip28_1.BorderRadius = 5;
            eventChip28_1.Cursor = Cursors.Hand;
            eventChip28_1.FlatStyle = FlatStyle.Flat;
            eventChip28_1.Font = new Font("Segoe UI", 7F);
            eventChip28_1.ForeColor = Color.White;
            eventChip28_1.HoverColor = Color.Empty;
            eventChip28_1.Location = new Point(0, 19);
            eventChip28_1.Margin = new Padding(0, 1, 0, 1);
            eventChip28_1.Name = "eventChip28_1";
            eventChip28_1.PressedColor = Color.Empty;
            eventChip28_1.Size = new Size(145, 16);
            eventChip28_1.TabIndex = 1;
            eventChip28_1.Text = "Another event";
            eventChip28_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip28_1.UseVisualStyleBackColor = false;
            eventChip28_1.Click += EventChip_Click;
            // 
            // moreEvents28
            // 
            moreEvents28.Cursor = Cursors.Hand;
            moreEvents28.Font = new Font("Segoe UI", 7F);
            moreEvents28.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents28.Location = new Point(3, 36);
            moreEvents28.Name = "moreEvents28";
            moreEvents28.Size = new Size(100, 15);
            moreEvents28.TabIndex = 2;
            moreEvents28.Text = "+1 more";
            moreEvents28.Click += DayCell_Click;
            // 
            // dayNumber28
            // 
            dayNumber28.BackColor = Color.Transparent;
            dayNumber28.Cursor = Cursors.Hand;
            dayNumber28.Dock = DockStyle.Top;
            dayNumber28.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber28.ForeColor = Color.White;
            dayNumber28.Location = new Point(3, 3);
            dayNumber28.Name = "dayNumber28";
            dayNumber28.Size = new Size(162, 17);
            dayNumber28.TabIndex = 1;
            dayNumber28.Text = "25";
            dayNumber28.Click += DayCell_Click;
            // 
            // dayCell29
            // 
            dayCell29.BackColor = Color.FromArgb(22, 33, 62);
            dayCell29.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell29.BorderWidth = 1;
            dayCell29.Controls.Add(dayEvents29);
            dayCell29.Controls.Add(dayNumber29);
            dayCell29.CornerRadius = 5;
            dayCell29.Cursor = Cursors.Hand;
            dayCell29.Dock = DockStyle.Fill;
            dayCell29.Location = new Point(171, 358);
            dayCell29.Margin = new Padding(1);
            dayCell29.Name = "dayCell29";
            dayCell29.Padding = new Padding(3);
            dayCell29.Size = new Size(168, 81);
            dayCell29.TabIndex = 36;
            dayCell29.Click += DayCell_Click;
            // 
            // dayEvents29
            // 
            dayEvents29.BackColor = Color.Transparent;
            dayEvents29.Controls.Add(eventChip29_0);
            dayEvents29.Controls.Add(eventChip29_1);
            dayEvents29.Controls.Add(moreEvents29);
            dayEvents29.Dock = DockStyle.Fill;
            dayEvents29.FlowDirection = FlowDirection.TopDown;
            dayEvents29.Location = new Point(3, 20);
            dayEvents29.Margin = new Padding(0);
            dayEvents29.Name = "dayEvents29";
            dayEvents29.Size = new Size(162, 58);
            dayEvents29.TabIndex = 0;
            dayEvents29.WrapContents = false;
            // 
            // eventChip29_0
            // 
            eventChip29_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip29_0.BorderColor = Color.White;
            eventChip29_0.BorderRadius = 5;
            eventChip29_0.Cursor = Cursors.Hand;
            eventChip29_0.FlatStyle = FlatStyle.Flat;
            eventChip29_0.Font = new Font("Segoe UI", 7F);
            eventChip29_0.ForeColor = Color.White;
            eventChip29_0.HoverColor = Color.Empty;
            eventChip29_0.Location = new Point(0, 1);
            eventChip29_0.Margin = new Padding(0, 1, 0, 1);
            eventChip29_0.Name = "eventChip29_0";
            eventChip29_0.PressedColor = Color.Empty;
            eventChip29_0.Size = new Size(145, 16);
            eventChip29_0.TabIndex = 0;
            eventChip29_0.Text = "Event title";
            eventChip29_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip29_0.UseVisualStyleBackColor = false;
            eventChip29_0.Click += EventChip_Click;
            // 
            // eventChip29_1
            // 
            eventChip29_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip29_1.BorderColor = Color.White;
            eventChip29_1.BorderRadius = 5;
            eventChip29_1.Cursor = Cursors.Hand;
            eventChip29_1.FlatStyle = FlatStyle.Flat;
            eventChip29_1.Font = new Font("Segoe UI", 7F);
            eventChip29_1.ForeColor = Color.White;
            eventChip29_1.HoverColor = Color.Empty;
            eventChip29_1.Location = new Point(0, 19);
            eventChip29_1.Margin = new Padding(0, 1, 0, 1);
            eventChip29_1.Name = "eventChip29_1";
            eventChip29_1.PressedColor = Color.Empty;
            eventChip29_1.Size = new Size(145, 16);
            eventChip29_1.TabIndex = 1;
            eventChip29_1.Text = "Another event";
            eventChip29_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip29_1.UseVisualStyleBackColor = false;
            eventChip29_1.Click += EventChip_Click;
            // 
            // moreEvents29
            // 
            moreEvents29.Cursor = Cursors.Hand;
            moreEvents29.Font = new Font("Segoe UI", 7F);
            moreEvents29.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents29.Location = new Point(3, 36);
            moreEvents29.Name = "moreEvents29";
            moreEvents29.Size = new Size(100, 15);
            moreEvents29.TabIndex = 2;
            moreEvents29.Text = "+1 more";
            moreEvents29.Click += DayCell_Click;
            // 
            // dayNumber29
            // 
            dayNumber29.BackColor = Color.Transparent;
            dayNumber29.Cursor = Cursors.Hand;
            dayNumber29.Dock = DockStyle.Top;
            dayNumber29.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber29.ForeColor = Color.White;
            dayNumber29.Location = new Point(3, 3);
            dayNumber29.Name = "dayNumber29";
            dayNumber29.Size = new Size(162, 17);
            dayNumber29.TabIndex = 1;
            dayNumber29.Text = "26";
            dayNumber29.Click += DayCell_Click;
            // 
            // dayCell30
            // 
            dayCell30.BackColor = Color.FromArgb(22, 33, 62);
            dayCell30.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell30.BorderWidth = 1;
            dayCell30.Controls.Add(dayEvents30);
            dayCell30.Controls.Add(dayNumber30);
            dayCell30.CornerRadius = 5;
            dayCell30.Cursor = Cursors.Hand;
            dayCell30.Dock = DockStyle.Fill;
            dayCell30.Location = new Point(341, 358);
            dayCell30.Margin = new Padding(1);
            dayCell30.Name = "dayCell30";
            dayCell30.Padding = new Padding(3);
            dayCell30.Size = new Size(168, 81);
            dayCell30.TabIndex = 37;
            dayCell30.Click += DayCell_Click;
            // 
            // dayEvents30
            // 
            dayEvents30.BackColor = Color.Transparent;
            dayEvents30.Controls.Add(eventChip30_0);
            dayEvents30.Controls.Add(eventChip30_1);
            dayEvents30.Controls.Add(moreEvents30);
            dayEvents30.Dock = DockStyle.Fill;
            dayEvents30.FlowDirection = FlowDirection.TopDown;
            dayEvents30.Location = new Point(3, 20);
            dayEvents30.Margin = new Padding(0);
            dayEvents30.Name = "dayEvents30";
            dayEvents30.Size = new Size(162, 58);
            dayEvents30.TabIndex = 0;
            dayEvents30.WrapContents = false;
            // 
            // eventChip30_0
            // 
            eventChip30_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip30_0.BorderColor = Color.White;
            eventChip30_0.BorderRadius = 5;
            eventChip30_0.Cursor = Cursors.Hand;
            eventChip30_0.FlatStyle = FlatStyle.Flat;
            eventChip30_0.Font = new Font("Segoe UI", 7F);
            eventChip30_0.ForeColor = Color.White;
            eventChip30_0.HoverColor = Color.Empty;
            eventChip30_0.Location = new Point(0, 1);
            eventChip30_0.Margin = new Padding(0, 1, 0, 1);
            eventChip30_0.Name = "eventChip30_0";
            eventChip30_0.PressedColor = Color.Empty;
            eventChip30_0.Size = new Size(145, 16);
            eventChip30_0.TabIndex = 0;
            eventChip30_0.Text = "Event title";
            eventChip30_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip30_0.UseVisualStyleBackColor = false;
            eventChip30_0.Click += EventChip_Click;
            // 
            // eventChip30_1
            // 
            eventChip30_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip30_1.BorderColor = Color.White;
            eventChip30_1.BorderRadius = 5;
            eventChip30_1.Cursor = Cursors.Hand;
            eventChip30_1.FlatStyle = FlatStyle.Flat;
            eventChip30_1.Font = new Font("Segoe UI", 7F);
            eventChip30_1.ForeColor = Color.White;
            eventChip30_1.HoverColor = Color.Empty;
            eventChip30_1.Location = new Point(0, 19);
            eventChip30_1.Margin = new Padding(0, 1, 0, 1);
            eventChip30_1.Name = "eventChip30_1";
            eventChip30_1.PressedColor = Color.Empty;
            eventChip30_1.Size = new Size(145, 16);
            eventChip30_1.TabIndex = 1;
            eventChip30_1.Text = "Another event";
            eventChip30_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip30_1.UseVisualStyleBackColor = false;
            eventChip30_1.Click += EventChip_Click;
            // 
            // moreEvents30
            // 
            moreEvents30.Cursor = Cursors.Hand;
            moreEvents30.Font = new Font("Segoe UI", 7F);
            moreEvents30.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents30.Location = new Point(3, 36);
            moreEvents30.Name = "moreEvents30";
            moreEvents30.Size = new Size(100, 15);
            moreEvents30.TabIndex = 2;
            moreEvents30.Text = "+1 more";
            moreEvents30.Click += DayCell_Click;
            // 
            // dayNumber30
            // 
            dayNumber30.BackColor = Color.Transparent;
            dayNumber30.Cursor = Cursors.Hand;
            dayNumber30.Dock = DockStyle.Top;
            dayNumber30.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber30.ForeColor = Color.White;
            dayNumber30.Location = new Point(3, 3);
            dayNumber30.Name = "dayNumber30";
            dayNumber30.Size = new Size(162, 17);
            dayNumber30.TabIndex = 1;
            dayNumber30.Text = "27";
            dayNumber30.Click += DayCell_Click;
            // 
            // dayCell31
            // 
            dayCell31.BackColor = Color.FromArgb(22, 33, 62);
            dayCell31.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell31.BorderWidth = 1;
            dayCell31.Controls.Add(dayEvents31);
            dayCell31.Controls.Add(dayNumber31);
            dayCell31.CornerRadius = 5;
            dayCell31.Cursor = Cursors.Hand;
            dayCell31.Dock = DockStyle.Fill;
            dayCell31.Location = new Point(511, 358);
            dayCell31.Margin = new Padding(1);
            dayCell31.Name = "dayCell31";
            dayCell31.Padding = new Padding(3);
            dayCell31.Size = new Size(168, 81);
            dayCell31.TabIndex = 38;
            dayCell31.Click += DayCell_Click;
            // 
            // dayEvents31
            // 
            dayEvents31.BackColor = Color.Transparent;
            dayEvents31.Controls.Add(eventChip31_0);
            dayEvents31.Controls.Add(eventChip31_1);
            dayEvents31.Controls.Add(moreEvents31);
            dayEvents31.Dock = DockStyle.Fill;
            dayEvents31.FlowDirection = FlowDirection.TopDown;
            dayEvents31.Location = new Point(3, 20);
            dayEvents31.Margin = new Padding(0);
            dayEvents31.Name = "dayEvents31";
            dayEvents31.Size = new Size(162, 58);
            dayEvents31.TabIndex = 0;
            dayEvents31.WrapContents = false;
            // 
            // eventChip31_0
            // 
            eventChip31_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip31_0.BorderColor = Color.White;
            eventChip31_0.BorderRadius = 5;
            eventChip31_0.Cursor = Cursors.Hand;
            eventChip31_0.FlatStyle = FlatStyle.Flat;
            eventChip31_0.Font = new Font("Segoe UI", 7F);
            eventChip31_0.ForeColor = Color.White;
            eventChip31_0.HoverColor = Color.Empty;
            eventChip31_0.Location = new Point(0, 1);
            eventChip31_0.Margin = new Padding(0, 1, 0, 1);
            eventChip31_0.Name = "eventChip31_0";
            eventChip31_0.PressedColor = Color.Empty;
            eventChip31_0.Size = new Size(145, 16);
            eventChip31_0.TabIndex = 0;
            eventChip31_0.Text = "Event title";
            eventChip31_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip31_0.UseVisualStyleBackColor = false;
            eventChip31_0.Click += EventChip_Click;
            // 
            // eventChip31_1
            // 
            eventChip31_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip31_1.BorderColor = Color.White;
            eventChip31_1.BorderRadius = 5;
            eventChip31_1.Cursor = Cursors.Hand;
            eventChip31_1.FlatStyle = FlatStyle.Flat;
            eventChip31_1.Font = new Font("Segoe UI", 7F);
            eventChip31_1.ForeColor = Color.White;
            eventChip31_1.HoverColor = Color.Empty;
            eventChip31_1.Location = new Point(0, 19);
            eventChip31_1.Margin = new Padding(0, 1, 0, 1);
            eventChip31_1.Name = "eventChip31_1";
            eventChip31_1.PressedColor = Color.Empty;
            eventChip31_1.Size = new Size(145, 16);
            eventChip31_1.TabIndex = 1;
            eventChip31_1.Text = "Another event";
            eventChip31_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip31_1.UseVisualStyleBackColor = false;
            eventChip31_1.Click += EventChip_Click;
            // 
            // moreEvents31
            // 
            moreEvents31.Cursor = Cursors.Hand;
            moreEvents31.Font = new Font("Segoe UI", 7F);
            moreEvents31.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents31.Location = new Point(3, 36);
            moreEvents31.Name = "moreEvents31";
            moreEvents31.Size = new Size(100, 15);
            moreEvents31.TabIndex = 2;
            moreEvents31.Text = "+1 more";
            moreEvents31.Click += DayCell_Click;
            // 
            // dayNumber31
            // 
            dayNumber31.BackColor = Color.Transparent;
            dayNumber31.Cursor = Cursors.Hand;
            dayNumber31.Dock = DockStyle.Top;
            dayNumber31.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber31.ForeColor = Color.White;
            dayNumber31.Location = new Point(3, 3);
            dayNumber31.Name = "dayNumber31";
            dayNumber31.Size = new Size(162, 17);
            dayNumber31.TabIndex = 1;
            dayNumber31.Text = "28";
            dayNumber31.Click += DayCell_Click;
            // 
            // dayCell32
            // 
            dayCell32.BackColor = Color.FromArgb(22, 33, 62);
            dayCell32.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell32.BorderWidth = 1;
            dayCell32.Controls.Add(dayEvents32);
            dayCell32.Controls.Add(dayNumber32);
            dayCell32.CornerRadius = 5;
            dayCell32.Cursor = Cursors.Hand;
            dayCell32.Dock = DockStyle.Fill;
            dayCell32.Location = new Point(681, 358);
            dayCell32.Margin = new Padding(1);
            dayCell32.Name = "dayCell32";
            dayCell32.Padding = new Padding(3);
            dayCell32.Size = new Size(168, 81);
            dayCell32.TabIndex = 39;
            dayCell32.Click += DayCell_Click;
            // 
            // dayEvents32
            // 
            dayEvents32.BackColor = Color.Transparent;
            dayEvents32.Controls.Add(eventChip32_0);
            dayEvents32.Controls.Add(eventChip32_1);
            dayEvents32.Controls.Add(moreEvents32);
            dayEvents32.Dock = DockStyle.Fill;
            dayEvents32.FlowDirection = FlowDirection.TopDown;
            dayEvents32.Location = new Point(3, 20);
            dayEvents32.Margin = new Padding(0);
            dayEvents32.Name = "dayEvents32";
            dayEvents32.Size = new Size(162, 58);
            dayEvents32.TabIndex = 0;
            dayEvents32.WrapContents = false;
            // 
            // eventChip32_0
            // 
            eventChip32_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip32_0.BorderColor = Color.White;
            eventChip32_0.BorderRadius = 5;
            eventChip32_0.Cursor = Cursors.Hand;
            eventChip32_0.FlatStyle = FlatStyle.Flat;
            eventChip32_0.Font = new Font("Segoe UI", 7F);
            eventChip32_0.ForeColor = Color.White;
            eventChip32_0.HoverColor = Color.Empty;
            eventChip32_0.Location = new Point(0, 1);
            eventChip32_0.Margin = new Padding(0, 1, 0, 1);
            eventChip32_0.Name = "eventChip32_0";
            eventChip32_0.PressedColor = Color.Empty;
            eventChip32_0.Size = new Size(145, 16);
            eventChip32_0.TabIndex = 0;
            eventChip32_0.Text = "Event title";
            eventChip32_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip32_0.UseVisualStyleBackColor = false;
            eventChip32_0.Click += EventChip_Click;
            // 
            // eventChip32_1
            // 
            eventChip32_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip32_1.BorderColor = Color.White;
            eventChip32_1.BorderRadius = 5;
            eventChip32_1.Cursor = Cursors.Hand;
            eventChip32_1.FlatStyle = FlatStyle.Flat;
            eventChip32_1.Font = new Font("Segoe UI", 7F);
            eventChip32_1.ForeColor = Color.White;
            eventChip32_1.HoverColor = Color.Empty;
            eventChip32_1.Location = new Point(0, 19);
            eventChip32_1.Margin = new Padding(0, 1, 0, 1);
            eventChip32_1.Name = "eventChip32_1";
            eventChip32_1.PressedColor = Color.Empty;
            eventChip32_1.Size = new Size(145, 16);
            eventChip32_1.TabIndex = 1;
            eventChip32_1.Text = "Another event";
            eventChip32_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip32_1.UseVisualStyleBackColor = false;
            eventChip32_1.Click += EventChip_Click;
            // 
            // moreEvents32
            // 
            moreEvents32.Cursor = Cursors.Hand;
            moreEvents32.Font = new Font("Segoe UI", 7F);
            moreEvents32.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents32.Location = new Point(3, 36);
            moreEvents32.Name = "moreEvents32";
            moreEvents32.Size = new Size(100, 15);
            moreEvents32.TabIndex = 2;
            moreEvents32.Text = "+1 more";
            moreEvents32.Click += DayCell_Click;
            // 
            // dayNumber32
            // 
            dayNumber32.BackColor = Color.Transparent;
            dayNumber32.Cursor = Cursors.Hand;
            dayNumber32.Dock = DockStyle.Top;
            dayNumber32.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber32.ForeColor = Color.White;
            dayNumber32.Location = new Point(3, 3);
            dayNumber32.Name = "dayNumber32";
            dayNumber32.Size = new Size(162, 17);
            dayNumber32.TabIndex = 1;
            dayNumber32.Text = "29";
            dayNumber32.Click += DayCell_Click;
            // 
            // dayCell33
            // 
            dayCell33.BackColor = Color.FromArgb(22, 33, 62);
            dayCell33.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell33.BorderWidth = 1;
            dayCell33.Controls.Add(dayEvents33);
            dayCell33.Controls.Add(dayNumber33);
            dayCell33.CornerRadius = 5;
            dayCell33.Cursor = Cursors.Hand;
            dayCell33.Dock = DockStyle.Fill;
            dayCell33.Location = new Point(851, 358);
            dayCell33.Margin = new Padding(1);
            dayCell33.Name = "dayCell33";
            dayCell33.Padding = new Padding(3);
            dayCell33.Size = new Size(168, 81);
            dayCell33.TabIndex = 40;
            dayCell33.Click += DayCell_Click;
            // 
            // dayEvents33
            // 
            dayEvents33.BackColor = Color.Transparent;
            dayEvents33.Controls.Add(eventChip33_0);
            dayEvents33.Controls.Add(eventChip33_1);
            dayEvents33.Controls.Add(moreEvents33);
            dayEvents33.Dock = DockStyle.Fill;
            dayEvents33.FlowDirection = FlowDirection.TopDown;
            dayEvents33.Location = new Point(3, 20);
            dayEvents33.Margin = new Padding(0);
            dayEvents33.Name = "dayEvents33";
            dayEvents33.Size = new Size(162, 58);
            dayEvents33.TabIndex = 0;
            dayEvents33.WrapContents = false;
            // 
            // eventChip33_0
            // 
            eventChip33_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip33_0.BorderColor = Color.White;
            eventChip33_0.BorderRadius = 5;
            eventChip33_0.Cursor = Cursors.Hand;
            eventChip33_0.FlatStyle = FlatStyle.Flat;
            eventChip33_0.Font = new Font("Segoe UI", 7F);
            eventChip33_0.ForeColor = Color.White;
            eventChip33_0.HoverColor = Color.Empty;
            eventChip33_0.Location = new Point(0, 1);
            eventChip33_0.Margin = new Padding(0, 1, 0, 1);
            eventChip33_0.Name = "eventChip33_0";
            eventChip33_0.PressedColor = Color.Empty;
            eventChip33_0.Size = new Size(145, 16);
            eventChip33_0.TabIndex = 0;
            eventChip33_0.Text = "Event title";
            eventChip33_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip33_0.UseVisualStyleBackColor = false;
            eventChip33_0.Click += EventChip_Click;
            // 
            // eventChip33_1
            // 
            eventChip33_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip33_1.BorderColor = Color.White;
            eventChip33_1.BorderRadius = 5;
            eventChip33_1.Cursor = Cursors.Hand;
            eventChip33_1.FlatStyle = FlatStyle.Flat;
            eventChip33_1.Font = new Font("Segoe UI", 7F);
            eventChip33_1.ForeColor = Color.White;
            eventChip33_1.HoverColor = Color.Empty;
            eventChip33_1.Location = new Point(0, 19);
            eventChip33_1.Margin = new Padding(0, 1, 0, 1);
            eventChip33_1.Name = "eventChip33_1";
            eventChip33_1.PressedColor = Color.Empty;
            eventChip33_1.Size = new Size(145, 16);
            eventChip33_1.TabIndex = 1;
            eventChip33_1.Text = "Another event";
            eventChip33_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip33_1.UseVisualStyleBackColor = false;
            eventChip33_1.Click += EventChip_Click;
            // 
            // moreEvents33
            // 
            moreEvents33.Cursor = Cursors.Hand;
            moreEvents33.Font = new Font("Segoe UI", 7F);
            moreEvents33.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents33.Location = new Point(3, 36);
            moreEvents33.Name = "moreEvents33";
            moreEvents33.Size = new Size(100, 15);
            moreEvents33.TabIndex = 2;
            moreEvents33.Text = "+1 more";
            moreEvents33.Click += DayCell_Click;
            // 
            // dayNumber33
            // 
            dayNumber33.BackColor = Color.Transparent;
            dayNumber33.Cursor = Cursors.Hand;
            dayNumber33.Dock = DockStyle.Top;
            dayNumber33.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber33.ForeColor = Color.White;
            dayNumber33.Location = new Point(3, 3);
            dayNumber33.Name = "dayNumber33";
            dayNumber33.Size = new Size(162, 17);
            dayNumber33.TabIndex = 1;
            dayNumber33.Text = "30";
            dayNumber33.Click += DayCell_Click;
            // 
            // dayCell34
            // 
            dayCell34.BackColor = Color.FromArgb(18, 23, 45);
            dayCell34.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell34.BorderWidth = 1;
            dayCell34.Controls.Add(dayEvents34);
            dayCell34.Controls.Add(dayNumber34);
            dayCell34.CornerRadius = 5;
            dayCell34.Cursor = Cursors.Hand;
            dayCell34.Dock = DockStyle.Fill;
            dayCell34.Location = new Point(1021, 358);
            dayCell34.Margin = new Padding(1);
            dayCell34.Name = "dayCell34";
            dayCell34.Padding = new Padding(3);
            dayCell34.Size = new Size(170, 81);
            dayCell34.TabIndex = 41;
            dayCell34.Click += DayCell_Click;
            // 
            // dayEvents34
            // 
            dayEvents34.BackColor = Color.Transparent;
            dayEvents34.Controls.Add(eventChip34_0);
            dayEvents34.Controls.Add(eventChip34_1);
            dayEvents34.Controls.Add(moreEvents34);
            dayEvents34.Dock = DockStyle.Fill;
            dayEvents34.FlowDirection = FlowDirection.TopDown;
            dayEvents34.Location = new Point(3, 20);
            dayEvents34.Margin = new Padding(0);
            dayEvents34.Name = "dayEvents34";
            dayEvents34.Size = new Size(164, 58);
            dayEvents34.TabIndex = 0;
            dayEvents34.WrapContents = false;
            // 
            // eventChip34_0
            // 
            eventChip34_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip34_0.BorderColor = Color.White;
            eventChip34_0.BorderRadius = 5;
            eventChip34_0.Cursor = Cursors.Hand;
            eventChip34_0.FlatStyle = FlatStyle.Flat;
            eventChip34_0.Font = new Font("Segoe UI", 7F);
            eventChip34_0.ForeColor = Color.White;
            eventChip34_0.HoverColor = Color.Empty;
            eventChip34_0.Location = new Point(0, 1);
            eventChip34_0.Margin = new Padding(0, 1, 0, 1);
            eventChip34_0.Name = "eventChip34_0";
            eventChip34_0.PressedColor = Color.Empty;
            eventChip34_0.Size = new Size(145, 16);
            eventChip34_0.TabIndex = 0;
            eventChip34_0.Text = "Event title";
            eventChip34_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip34_0.UseVisualStyleBackColor = false;
            eventChip34_0.Click += EventChip_Click;
            // 
            // eventChip34_1
            // 
            eventChip34_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip34_1.BorderColor = Color.White;
            eventChip34_1.BorderRadius = 5;
            eventChip34_1.Cursor = Cursors.Hand;
            eventChip34_1.FlatStyle = FlatStyle.Flat;
            eventChip34_1.Font = new Font("Segoe UI", 7F);
            eventChip34_1.ForeColor = Color.White;
            eventChip34_1.HoverColor = Color.Empty;
            eventChip34_1.Location = new Point(0, 19);
            eventChip34_1.Margin = new Padding(0, 1, 0, 1);
            eventChip34_1.Name = "eventChip34_1";
            eventChip34_1.PressedColor = Color.Empty;
            eventChip34_1.Size = new Size(145, 16);
            eventChip34_1.TabIndex = 1;
            eventChip34_1.Text = "Another event";
            eventChip34_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip34_1.UseVisualStyleBackColor = false;
            eventChip34_1.Click += EventChip_Click;
            // 
            // moreEvents34
            // 
            moreEvents34.Cursor = Cursors.Hand;
            moreEvents34.Font = new Font("Segoe UI", 7F);
            moreEvents34.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents34.Location = new Point(3, 36);
            moreEvents34.Name = "moreEvents34";
            moreEvents34.Size = new Size(100, 15);
            moreEvents34.TabIndex = 2;
            moreEvents34.Text = "+1 more";
            moreEvents34.Click += DayCell_Click;
            // 
            // dayNumber34
            // 
            dayNumber34.BackColor = Color.Transparent;
            dayNumber34.Cursor = Cursors.Hand;
            dayNumber34.Dock = DockStyle.Top;
            dayNumber34.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber34.ForeColor = Color.White;
            dayNumber34.Location = new Point(3, 3);
            dayNumber34.Name = "dayNumber34";
            dayNumber34.Size = new Size(164, 17);
            dayNumber34.TabIndex = 1;
            dayNumber34.Text = "31";
            dayNumber34.Click += DayCell_Click;
            // 
            // dayCell35
            // 
            dayCell35.BackColor = Color.FromArgb(18, 23, 45);
            dayCell35.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell35.BorderWidth = 1;
            dayCell35.Controls.Add(dayEvents35);
            dayCell35.Controls.Add(dayNumber35);
            dayCell35.CornerRadius = 5;
            dayCell35.Cursor = Cursors.Hand;
            dayCell35.Dock = DockStyle.Fill;
            dayCell35.Location = new Point(1, 441);
            dayCell35.Margin = new Padding(1);
            dayCell35.Name = "dayCell35";
            dayCell35.Padding = new Padding(3);
            dayCell35.Size = new Size(168, 85);
            dayCell35.TabIndex = 42;
            dayCell35.Click += DayCell_Click;
            // 
            // dayEvents35
            // 
            dayEvents35.BackColor = Color.Transparent;
            dayEvents35.Controls.Add(eventChip35_0);
            dayEvents35.Controls.Add(eventChip35_1);
            dayEvents35.Controls.Add(moreEvents35);
            dayEvents35.Dock = DockStyle.Fill;
            dayEvents35.FlowDirection = FlowDirection.TopDown;
            dayEvents35.Location = new Point(3, 20);
            dayEvents35.Margin = new Padding(0);
            dayEvents35.Name = "dayEvents35";
            dayEvents35.Size = new Size(162, 62);
            dayEvents35.TabIndex = 0;
            dayEvents35.WrapContents = false;
            // 
            // eventChip35_0
            // 
            eventChip35_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip35_0.BorderColor = Color.White;
            eventChip35_0.BorderRadius = 5;
            eventChip35_0.Cursor = Cursors.Hand;
            eventChip35_0.FlatStyle = FlatStyle.Flat;
            eventChip35_0.Font = new Font("Segoe UI", 7F);
            eventChip35_0.ForeColor = Color.White;
            eventChip35_0.HoverColor = Color.Empty;
            eventChip35_0.Location = new Point(0, 1);
            eventChip35_0.Margin = new Padding(0, 1, 0, 1);
            eventChip35_0.Name = "eventChip35_0";
            eventChip35_0.PressedColor = Color.Empty;
            eventChip35_0.Size = new Size(145, 16);
            eventChip35_0.TabIndex = 0;
            eventChip35_0.Text = "Event title";
            eventChip35_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip35_0.UseVisualStyleBackColor = false;
            eventChip35_0.Click += EventChip_Click;
            // 
            // eventChip35_1
            // 
            eventChip35_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip35_1.BorderColor = Color.White;
            eventChip35_1.BorderRadius = 5;
            eventChip35_1.Cursor = Cursors.Hand;
            eventChip35_1.FlatStyle = FlatStyle.Flat;
            eventChip35_1.Font = new Font("Segoe UI", 7F);
            eventChip35_1.ForeColor = Color.White;
            eventChip35_1.HoverColor = Color.Empty;
            eventChip35_1.Location = new Point(0, 19);
            eventChip35_1.Margin = new Padding(0, 1, 0, 1);
            eventChip35_1.Name = "eventChip35_1";
            eventChip35_1.PressedColor = Color.Empty;
            eventChip35_1.Size = new Size(145, 16);
            eventChip35_1.TabIndex = 1;
            eventChip35_1.Text = "Another event";
            eventChip35_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip35_1.UseVisualStyleBackColor = false;
            eventChip35_1.Click += EventChip_Click;
            // 
            // moreEvents35
            // 
            moreEvents35.Cursor = Cursors.Hand;
            moreEvents35.Font = new Font("Segoe UI", 7F);
            moreEvents35.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents35.Location = new Point(3, 36);
            moreEvents35.Name = "moreEvents35";
            moreEvents35.Size = new Size(100, 15);
            moreEvents35.TabIndex = 2;
            moreEvents35.Text = "+1 more";
            moreEvents35.Click += DayCell_Click;
            // 
            // dayNumber35
            // 
            dayNumber35.BackColor = Color.Transparent;
            dayNumber35.Cursor = Cursors.Hand;
            dayNumber35.Dock = DockStyle.Top;
            dayNumber35.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber35.ForeColor = Color.White;
            dayNumber35.Location = new Point(3, 3);
            dayNumber35.Name = "dayNumber35";
            dayNumber35.Size = new Size(162, 17);
            dayNumber35.TabIndex = 1;
            dayNumber35.Text = "1";
            dayNumber35.Click += DayCell_Click;
            // 
            // dayCell36
            // 
            dayCell36.BackColor = Color.FromArgb(22, 33, 62);
            dayCell36.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell36.BorderWidth = 1;
            dayCell36.Controls.Add(dayEvents36);
            dayCell36.Controls.Add(dayNumber36);
            dayCell36.CornerRadius = 5;
            dayCell36.Cursor = Cursors.Hand;
            dayCell36.Dock = DockStyle.Fill;
            dayCell36.Location = new Point(171, 441);
            dayCell36.Margin = new Padding(1);
            dayCell36.Name = "dayCell36";
            dayCell36.Padding = new Padding(3);
            dayCell36.Size = new Size(168, 85);
            dayCell36.TabIndex = 43;
            dayCell36.Click += DayCell_Click;
            // 
            // dayEvents36
            // 
            dayEvents36.BackColor = Color.Transparent;
            dayEvents36.Controls.Add(eventChip36_0);
            dayEvents36.Controls.Add(eventChip36_1);
            dayEvents36.Controls.Add(moreEvents36);
            dayEvents36.Dock = DockStyle.Fill;
            dayEvents36.FlowDirection = FlowDirection.TopDown;
            dayEvents36.Location = new Point(3, 20);
            dayEvents36.Margin = new Padding(0);
            dayEvents36.Name = "dayEvents36";
            dayEvents36.Size = new Size(162, 62);
            dayEvents36.TabIndex = 0;
            dayEvents36.WrapContents = false;
            // 
            // eventChip36_0
            // 
            eventChip36_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip36_0.BorderColor = Color.White;
            eventChip36_0.BorderRadius = 5;
            eventChip36_0.Cursor = Cursors.Hand;
            eventChip36_0.FlatStyle = FlatStyle.Flat;
            eventChip36_0.Font = new Font("Segoe UI", 7F);
            eventChip36_0.ForeColor = Color.White;
            eventChip36_0.HoverColor = Color.Empty;
            eventChip36_0.Location = new Point(0, 1);
            eventChip36_0.Margin = new Padding(0, 1, 0, 1);
            eventChip36_0.Name = "eventChip36_0";
            eventChip36_0.PressedColor = Color.Empty;
            eventChip36_0.Size = new Size(145, 16);
            eventChip36_0.TabIndex = 0;
            eventChip36_0.Text = "Event title";
            eventChip36_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip36_0.UseVisualStyleBackColor = false;
            eventChip36_0.Click += EventChip_Click;
            // 
            // eventChip36_1
            // 
            eventChip36_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip36_1.BorderColor = Color.White;
            eventChip36_1.BorderRadius = 5;
            eventChip36_1.Cursor = Cursors.Hand;
            eventChip36_1.FlatStyle = FlatStyle.Flat;
            eventChip36_1.Font = new Font("Segoe UI", 7F);
            eventChip36_1.ForeColor = Color.White;
            eventChip36_1.HoverColor = Color.Empty;
            eventChip36_1.Location = new Point(0, 19);
            eventChip36_1.Margin = new Padding(0, 1, 0, 1);
            eventChip36_1.Name = "eventChip36_1";
            eventChip36_1.PressedColor = Color.Empty;
            eventChip36_1.Size = new Size(145, 16);
            eventChip36_1.TabIndex = 1;
            eventChip36_1.Text = "Another event";
            eventChip36_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip36_1.UseVisualStyleBackColor = false;
            eventChip36_1.Click += EventChip_Click;
            // 
            // moreEvents36
            // 
            moreEvents36.Cursor = Cursors.Hand;
            moreEvents36.Font = new Font("Segoe UI", 7F);
            moreEvents36.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents36.Location = new Point(3, 36);
            moreEvents36.Name = "moreEvents36";
            moreEvents36.Size = new Size(100, 15);
            moreEvents36.TabIndex = 2;
            moreEvents36.Text = "+1 more";
            moreEvents36.Click += DayCell_Click;
            // 
            // dayNumber36
            // 
            dayNumber36.BackColor = Color.Transparent;
            dayNumber36.Cursor = Cursors.Hand;
            dayNumber36.Dock = DockStyle.Top;
            dayNumber36.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber36.ForeColor = Color.White;
            dayNumber36.Location = new Point(3, 3);
            dayNumber36.Name = "dayNumber36";
            dayNumber36.Size = new Size(162, 17);
            dayNumber36.TabIndex = 1;
            dayNumber36.Text = "2";
            dayNumber36.Click += DayCell_Click;
            // 
            // dayCell37
            // 
            dayCell37.BackColor = Color.FromArgb(22, 33, 62);
            dayCell37.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell37.BorderWidth = 1;
            dayCell37.Controls.Add(dayEvents37);
            dayCell37.Controls.Add(dayNumber37);
            dayCell37.CornerRadius = 5;
            dayCell37.Cursor = Cursors.Hand;
            dayCell37.Dock = DockStyle.Fill;
            dayCell37.Location = new Point(341, 441);
            dayCell37.Margin = new Padding(1);
            dayCell37.Name = "dayCell37";
            dayCell37.Padding = new Padding(3);
            dayCell37.Size = new Size(168, 85);
            dayCell37.TabIndex = 44;
            dayCell37.Click += DayCell_Click;
            // 
            // dayEvents37
            // 
            dayEvents37.BackColor = Color.Transparent;
            dayEvents37.Controls.Add(eventChip37_0);
            dayEvents37.Controls.Add(eventChip37_1);
            dayEvents37.Controls.Add(moreEvents37);
            dayEvents37.Dock = DockStyle.Fill;
            dayEvents37.FlowDirection = FlowDirection.TopDown;
            dayEvents37.Location = new Point(3, 20);
            dayEvents37.Margin = new Padding(0);
            dayEvents37.Name = "dayEvents37";
            dayEvents37.Size = new Size(162, 62);
            dayEvents37.TabIndex = 0;
            dayEvents37.WrapContents = false;
            // 
            // eventChip37_0
            // 
            eventChip37_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip37_0.BorderColor = Color.White;
            eventChip37_0.BorderRadius = 5;
            eventChip37_0.Cursor = Cursors.Hand;
            eventChip37_0.FlatStyle = FlatStyle.Flat;
            eventChip37_0.Font = new Font("Segoe UI", 7F);
            eventChip37_0.ForeColor = Color.White;
            eventChip37_0.HoverColor = Color.Empty;
            eventChip37_0.Location = new Point(0, 1);
            eventChip37_0.Margin = new Padding(0, 1, 0, 1);
            eventChip37_0.Name = "eventChip37_0";
            eventChip37_0.PressedColor = Color.Empty;
            eventChip37_0.Size = new Size(145, 16);
            eventChip37_0.TabIndex = 0;
            eventChip37_0.Text = "Event title";
            eventChip37_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip37_0.UseVisualStyleBackColor = false;
            eventChip37_0.Click += EventChip_Click;
            // 
            // eventChip37_1
            // 
            eventChip37_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip37_1.BorderColor = Color.White;
            eventChip37_1.BorderRadius = 5;
            eventChip37_1.Cursor = Cursors.Hand;
            eventChip37_1.FlatStyle = FlatStyle.Flat;
            eventChip37_1.Font = new Font("Segoe UI", 7F);
            eventChip37_1.ForeColor = Color.White;
            eventChip37_1.HoverColor = Color.Empty;
            eventChip37_1.Location = new Point(0, 19);
            eventChip37_1.Margin = new Padding(0, 1, 0, 1);
            eventChip37_1.Name = "eventChip37_1";
            eventChip37_1.PressedColor = Color.Empty;
            eventChip37_1.Size = new Size(145, 16);
            eventChip37_1.TabIndex = 1;
            eventChip37_1.Text = "Another event";
            eventChip37_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip37_1.UseVisualStyleBackColor = false;
            eventChip37_1.Click += EventChip_Click;
            // 
            // moreEvents37
            // 
            moreEvents37.Cursor = Cursors.Hand;
            moreEvents37.Font = new Font("Segoe UI", 7F);
            moreEvents37.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents37.Location = new Point(3, 36);
            moreEvents37.Name = "moreEvents37";
            moreEvents37.Size = new Size(100, 15);
            moreEvents37.TabIndex = 2;
            moreEvents37.Text = "+1 more";
            moreEvents37.Click += DayCell_Click;
            // 
            // dayNumber37
            // 
            dayNumber37.BackColor = Color.Transparent;
            dayNumber37.Cursor = Cursors.Hand;
            dayNumber37.Dock = DockStyle.Top;
            dayNumber37.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber37.ForeColor = Color.White;
            dayNumber37.Location = new Point(3, 3);
            dayNumber37.Name = "dayNumber37";
            dayNumber37.Size = new Size(162, 17);
            dayNumber37.TabIndex = 1;
            dayNumber37.Text = "3";
            dayNumber37.Click += DayCell_Click;
            // 
            // dayCell38
            // 
            dayCell38.BackColor = Color.FromArgb(22, 33, 62);
            dayCell38.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell38.BorderWidth = 1;
            dayCell38.Controls.Add(dayEvents38);
            dayCell38.Controls.Add(dayNumber38);
            dayCell38.CornerRadius = 5;
            dayCell38.Cursor = Cursors.Hand;
            dayCell38.Dock = DockStyle.Fill;
            dayCell38.Location = new Point(511, 441);
            dayCell38.Margin = new Padding(1);
            dayCell38.Name = "dayCell38";
            dayCell38.Padding = new Padding(3);
            dayCell38.Size = new Size(168, 85);
            dayCell38.TabIndex = 45;
            dayCell38.Click += DayCell_Click;
            // 
            // dayEvents38
            // 
            dayEvents38.BackColor = Color.Transparent;
            dayEvents38.Controls.Add(eventChip38_0);
            dayEvents38.Controls.Add(eventChip38_1);
            dayEvents38.Controls.Add(moreEvents38);
            dayEvents38.Dock = DockStyle.Fill;
            dayEvents38.FlowDirection = FlowDirection.TopDown;
            dayEvents38.Location = new Point(3, 20);
            dayEvents38.Margin = new Padding(0);
            dayEvents38.Name = "dayEvents38";
            dayEvents38.Size = new Size(162, 62);
            dayEvents38.TabIndex = 0;
            dayEvents38.WrapContents = false;
            // 
            // eventChip38_0
            // 
            eventChip38_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip38_0.BorderColor = Color.White;
            eventChip38_0.BorderRadius = 5;
            eventChip38_0.Cursor = Cursors.Hand;
            eventChip38_0.FlatStyle = FlatStyle.Flat;
            eventChip38_0.Font = new Font("Segoe UI", 7F);
            eventChip38_0.ForeColor = Color.White;
            eventChip38_0.HoverColor = Color.Empty;
            eventChip38_0.Location = new Point(0, 1);
            eventChip38_0.Margin = new Padding(0, 1, 0, 1);
            eventChip38_0.Name = "eventChip38_0";
            eventChip38_0.PressedColor = Color.Empty;
            eventChip38_0.Size = new Size(145, 16);
            eventChip38_0.TabIndex = 0;
            eventChip38_0.Text = "Event title";
            eventChip38_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip38_0.UseVisualStyleBackColor = false;
            eventChip38_0.Click += EventChip_Click;
            // 
            // eventChip38_1
            // 
            eventChip38_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip38_1.BorderColor = Color.White;
            eventChip38_1.BorderRadius = 5;
            eventChip38_1.Cursor = Cursors.Hand;
            eventChip38_1.FlatStyle = FlatStyle.Flat;
            eventChip38_1.Font = new Font("Segoe UI", 7F);
            eventChip38_1.ForeColor = Color.White;
            eventChip38_1.HoverColor = Color.Empty;
            eventChip38_1.Location = new Point(0, 19);
            eventChip38_1.Margin = new Padding(0, 1, 0, 1);
            eventChip38_1.Name = "eventChip38_1";
            eventChip38_1.PressedColor = Color.Empty;
            eventChip38_1.Size = new Size(145, 16);
            eventChip38_1.TabIndex = 1;
            eventChip38_1.Text = "Another event";
            eventChip38_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip38_1.UseVisualStyleBackColor = false;
            eventChip38_1.Click += EventChip_Click;
            // 
            // moreEvents38
            // 
            moreEvents38.Cursor = Cursors.Hand;
            moreEvents38.Font = new Font("Segoe UI", 7F);
            moreEvents38.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents38.Location = new Point(3, 36);
            moreEvents38.Name = "moreEvents38";
            moreEvents38.Size = new Size(100, 15);
            moreEvents38.TabIndex = 2;
            moreEvents38.Text = "+1 more";
            moreEvents38.Click += DayCell_Click;
            // 
            // dayNumber38
            // 
            dayNumber38.BackColor = Color.Transparent;
            dayNumber38.Cursor = Cursors.Hand;
            dayNumber38.Dock = DockStyle.Top;
            dayNumber38.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber38.ForeColor = Color.White;
            dayNumber38.Location = new Point(3, 3);
            dayNumber38.Name = "dayNumber38";
            dayNumber38.Size = new Size(162, 17);
            dayNumber38.TabIndex = 1;
            dayNumber38.Text = "4";
            dayNumber38.Click += DayCell_Click;
            // 
            // dayCell39
            // 
            dayCell39.BackColor = Color.FromArgb(22, 33, 62);
            dayCell39.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell39.BorderWidth = 1;
            dayCell39.Controls.Add(dayEvents39);
            dayCell39.Controls.Add(dayNumber39);
            dayCell39.CornerRadius = 5;
            dayCell39.Cursor = Cursors.Hand;
            dayCell39.Dock = DockStyle.Fill;
            dayCell39.Location = new Point(681, 441);
            dayCell39.Margin = new Padding(1);
            dayCell39.Name = "dayCell39";
            dayCell39.Padding = new Padding(3);
            dayCell39.Size = new Size(168, 85);
            dayCell39.TabIndex = 46;
            dayCell39.Click += DayCell_Click;
            // 
            // dayEvents39
            // 
            dayEvents39.BackColor = Color.Transparent;
            dayEvents39.Controls.Add(eventChip39_0);
            dayEvents39.Controls.Add(eventChip39_1);
            dayEvents39.Controls.Add(moreEvents39);
            dayEvents39.Dock = DockStyle.Fill;
            dayEvents39.FlowDirection = FlowDirection.TopDown;
            dayEvents39.Location = new Point(3, 20);
            dayEvents39.Margin = new Padding(0);
            dayEvents39.Name = "dayEvents39";
            dayEvents39.Size = new Size(162, 62);
            dayEvents39.TabIndex = 0;
            dayEvents39.WrapContents = false;
            // 
            // eventChip39_0
            // 
            eventChip39_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip39_0.BorderColor = Color.White;
            eventChip39_0.BorderRadius = 5;
            eventChip39_0.Cursor = Cursors.Hand;
            eventChip39_0.FlatStyle = FlatStyle.Flat;
            eventChip39_0.Font = new Font("Segoe UI", 7F);
            eventChip39_0.ForeColor = Color.White;
            eventChip39_0.HoverColor = Color.Empty;
            eventChip39_0.Location = new Point(0, 1);
            eventChip39_0.Margin = new Padding(0, 1, 0, 1);
            eventChip39_0.Name = "eventChip39_0";
            eventChip39_0.PressedColor = Color.Empty;
            eventChip39_0.Size = new Size(145, 16);
            eventChip39_0.TabIndex = 0;
            eventChip39_0.Text = "Event title";
            eventChip39_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip39_0.UseVisualStyleBackColor = false;
            eventChip39_0.Click += EventChip_Click;
            // 
            // eventChip39_1
            // 
            eventChip39_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip39_1.BorderColor = Color.White;
            eventChip39_1.BorderRadius = 5;
            eventChip39_1.Cursor = Cursors.Hand;
            eventChip39_1.FlatStyle = FlatStyle.Flat;
            eventChip39_1.Font = new Font("Segoe UI", 7F);
            eventChip39_1.ForeColor = Color.White;
            eventChip39_1.HoverColor = Color.Empty;
            eventChip39_1.Location = new Point(0, 19);
            eventChip39_1.Margin = new Padding(0, 1, 0, 1);
            eventChip39_1.Name = "eventChip39_1";
            eventChip39_1.PressedColor = Color.Empty;
            eventChip39_1.Size = new Size(145, 16);
            eventChip39_1.TabIndex = 1;
            eventChip39_1.Text = "Another event";
            eventChip39_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip39_1.UseVisualStyleBackColor = false;
            eventChip39_1.Click += EventChip_Click;
            // 
            // moreEvents39
            // 
            moreEvents39.Cursor = Cursors.Hand;
            moreEvents39.Font = new Font("Segoe UI", 7F);
            moreEvents39.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents39.Location = new Point(3, 36);
            moreEvents39.Name = "moreEvents39";
            moreEvents39.Size = new Size(100, 15);
            moreEvents39.TabIndex = 2;
            moreEvents39.Text = "+1 more";
            moreEvents39.Click += DayCell_Click;
            // 
            // dayNumber39
            // 
            dayNumber39.BackColor = Color.Transparent;
            dayNumber39.Cursor = Cursors.Hand;
            dayNumber39.Dock = DockStyle.Top;
            dayNumber39.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber39.ForeColor = Color.White;
            dayNumber39.Location = new Point(3, 3);
            dayNumber39.Name = "dayNumber39";
            dayNumber39.Size = new Size(162, 17);
            dayNumber39.TabIndex = 1;
            dayNumber39.Text = "5";
            dayNumber39.Click += DayCell_Click;
            // 
            // dayCell40
            // 
            dayCell40.BackColor = Color.FromArgb(22, 33, 62);
            dayCell40.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell40.BorderWidth = 1;
            dayCell40.Controls.Add(dayEvents40);
            dayCell40.Controls.Add(dayNumber40);
            dayCell40.CornerRadius = 5;
            dayCell40.Cursor = Cursors.Hand;
            dayCell40.Dock = DockStyle.Fill;
            dayCell40.Location = new Point(851, 441);
            dayCell40.Margin = new Padding(1);
            dayCell40.Name = "dayCell40";
            dayCell40.Padding = new Padding(3);
            dayCell40.Size = new Size(168, 85);
            dayCell40.TabIndex = 47;
            dayCell40.Click += DayCell_Click;
            // 
            // dayEvents40
            // 
            dayEvents40.BackColor = Color.Transparent;
            dayEvents40.Controls.Add(eventChip40_0);
            dayEvents40.Controls.Add(eventChip40_1);
            dayEvents40.Controls.Add(moreEvents40);
            dayEvents40.Dock = DockStyle.Fill;
            dayEvents40.FlowDirection = FlowDirection.TopDown;
            dayEvents40.Location = new Point(3, 20);
            dayEvents40.Margin = new Padding(0);
            dayEvents40.Name = "dayEvents40";
            dayEvents40.Size = new Size(162, 62);
            dayEvents40.TabIndex = 0;
            dayEvents40.WrapContents = false;
            // 
            // eventChip40_0
            // 
            eventChip40_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip40_0.BorderColor = Color.White;
            eventChip40_0.BorderRadius = 5;
            eventChip40_0.Cursor = Cursors.Hand;
            eventChip40_0.FlatStyle = FlatStyle.Flat;
            eventChip40_0.Font = new Font("Segoe UI", 7F);
            eventChip40_0.ForeColor = Color.White;
            eventChip40_0.HoverColor = Color.Empty;
            eventChip40_0.Location = new Point(0, 1);
            eventChip40_0.Margin = new Padding(0, 1, 0, 1);
            eventChip40_0.Name = "eventChip40_0";
            eventChip40_0.PressedColor = Color.Empty;
            eventChip40_0.Size = new Size(145, 16);
            eventChip40_0.TabIndex = 0;
            eventChip40_0.Text = "Event title";
            eventChip40_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip40_0.UseVisualStyleBackColor = false;
            eventChip40_0.Click += EventChip_Click;
            // 
            // eventChip40_1
            // 
            eventChip40_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip40_1.BorderColor = Color.White;
            eventChip40_1.BorderRadius = 5;
            eventChip40_1.Cursor = Cursors.Hand;
            eventChip40_1.FlatStyle = FlatStyle.Flat;
            eventChip40_1.Font = new Font("Segoe UI", 7F);
            eventChip40_1.ForeColor = Color.White;
            eventChip40_1.HoverColor = Color.Empty;
            eventChip40_1.Location = new Point(0, 19);
            eventChip40_1.Margin = new Padding(0, 1, 0, 1);
            eventChip40_1.Name = "eventChip40_1";
            eventChip40_1.PressedColor = Color.Empty;
            eventChip40_1.Size = new Size(145, 16);
            eventChip40_1.TabIndex = 1;
            eventChip40_1.Text = "Another event";
            eventChip40_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip40_1.UseVisualStyleBackColor = false;
            eventChip40_1.Click += EventChip_Click;
            // 
            // moreEvents40
            // 
            moreEvents40.Cursor = Cursors.Hand;
            moreEvents40.Font = new Font("Segoe UI", 7F);
            moreEvents40.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents40.Location = new Point(3, 36);
            moreEvents40.Name = "moreEvents40";
            moreEvents40.Size = new Size(100, 15);
            moreEvents40.TabIndex = 2;
            moreEvents40.Text = "+1 more";
            moreEvents40.Click += DayCell_Click;
            // 
            // dayNumber40
            // 
            dayNumber40.BackColor = Color.Transparent;
            dayNumber40.Cursor = Cursors.Hand;
            dayNumber40.Dock = DockStyle.Top;
            dayNumber40.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber40.ForeColor = Color.White;
            dayNumber40.Location = new Point(3, 3);
            dayNumber40.Name = "dayNumber40";
            dayNumber40.Size = new Size(162, 17);
            dayNumber40.TabIndex = 1;
            dayNumber40.Text = "6";
            dayNumber40.Click += DayCell_Click;
            // 
            // dayCell41
            // 
            dayCell41.BackColor = Color.FromArgb(18, 23, 45);
            dayCell41.BorderColor = Color.FromArgb(35, 43, 69);
            dayCell41.BorderWidth = 1;
            dayCell41.Controls.Add(dayEvents41);
            dayCell41.Controls.Add(dayNumber41);
            dayCell41.CornerRadius = 5;
            dayCell41.Cursor = Cursors.Hand;
            dayCell41.Dock = DockStyle.Fill;
            dayCell41.Location = new Point(1021, 441);
            dayCell41.Margin = new Padding(1);
            dayCell41.Name = "dayCell41";
            dayCell41.Padding = new Padding(3);
            dayCell41.Size = new Size(170, 85);
            dayCell41.TabIndex = 48;
            dayCell41.Click += DayCell_Click;
            // 
            // dayEvents41
            // 
            dayEvents41.BackColor = Color.Transparent;
            dayEvents41.Controls.Add(eventChip41_0);
            dayEvents41.Controls.Add(eventChip41_1);
            dayEvents41.Controls.Add(moreEvents41);
            dayEvents41.Dock = DockStyle.Fill;
            dayEvents41.FlowDirection = FlowDirection.TopDown;
            dayEvents41.Location = new Point(3, 20);
            dayEvents41.Margin = new Padding(0);
            dayEvents41.Name = "dayEvents41";
            dayEvents41.Size = new Size(164, 62);
            dayEvents41.TabIndex = 0;
            dayEvents41.WrapContents = false;
            // 
            // eventChip41_0
            // 
            eventChip41_0.BackColor = Color.FromArgb(204, 34, 68);
            eventChip41_0.BorderColor = Color.White;
            eventChip41_0.BorderRadius = 5;
            eventChip41_0.Cursor = Cursors.Hand;
            eventChip41_0.FlatStyle = FlatStyle.Flat;
            eventChip41_0.Font = new Font("Segoe UI", 7F);
            eventChip41_0.ForeColor = Color.White;
            eventChip41_0.HoverColor = Color.Empty;
            eventChip41_0.Location = new Point(0, 1);
            eventChip41_0.Margin = new Padding(0, 1, 0, 1);
            eventChip41_0.Name = "eventChip41_0";
            eventChip41_0.PressedColor = Color.Empty;
            eventChip41_0.Size = new Size(145, 16);
            eventChip41_0.TabIndex = 0;
            eventChip41_0.Text = "Event title";
            eventChip41_0.TextAlign = ContentAlignment.MiddleLeft;
            eventChip41_0.UseVisualStyleBackColor = false;
            eventChip41_0.Click += EventChip_Click;
            // 
            // eventChip41_1
            // 
            eventChip41_1.BackColor = Color.FromArgb(204, 34, 68);
            eventChip41_1.BorderColor = Color.White;
            eventChip41_1.BorderRadius = 5;
            eventChip41_1.Cursor = Cursors.Hand;
            eventChip41_1.FlatStyle = FlatStyle.Flat;
            eventChip41_1.Font = new Font("Segoe UI", 7F);
            eventChip41_1.ForeColor = Color.White;
            eventChip41_1.HoverColor = Color.Empty;
            eventChip41_1.Location = new Point(0, 19);
            eventChip41_1.Margin = new Padding(0, 1, 0, 1);
            eventChip41_1.Name = "eventChip41_1";
            eventChip41_1.PressedColor = Color.Empty;
            eventChip41_1.Size = new Size(145, 16);
            eventChip41_1.TabIndex = 1;
            eventChip41_1.Text = "Another event";
            eventChip41_1.TextAlign = ContentAlignment.MiddleLeft;
            eventChip41_1.UseVisualStyleBackColor = false;
            eventChip41_1.Click += EventChip_Click;
            // 
            // moreEvents41
            // 
            moreEvents41.Cursor = Cursors.Hand;
            moreEvents41.Font = new Font("Segoe UI", 7F);
            moreEvents41.ForeColor = Color.FromArgb(150, 150, 170);
            moreEvents41.Location = new Point(3, 36);
            moreEvents41.Name = "moreEvents41";
            moreEvents41.Size = new Size(100, 15);
            moreEvents41.TabIndex = 2;
            moreEvents41.Text = "+1 more";
            moreEvents41.Click += DayCell_Click;
            // 
            // dayNumber41
            // 
            dayNumber41.BackColor = Color.Transparent;
            dayNumber41.Cursor = Cursors.Hand;
            dayNumber41.Dock = DockStyle.Top;
            dayNumber41.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dayNumber41.ForeColor = Color.White;
            dayNumber41.Location = new Point(3, 3);
            dayNumber41.Name = "dayNumber41";
            dayNumber41.Size = new Size(164, 17);
            dayNumber41.TabIndex = 1;
            dayNumber41.Text = "7";
            dayNumber41.Click += DayCell_Click;
            // 
            // eventCard
            // 
            eventCard.BackColor = Color.FromArgb(22, 33, 62);
            eventCard.BorderColor = Color.FromArgb(22, 33, 62);
            eventCard.BorderWidth = 0;
            eventCard.Controls.Add(formRows);
            eventCard.CornerRadius = 5;
            eventCard.Dock = DockStyle.Fill;
            eventCard.Location = new Point(7, 578);
            eventCard.Name = "eventCard";
            eventCard.Padding = new Padding(10);
            eventCard.Size = new Size(1186, 283);
            eventCard.TabIndex = 2;
            // 
            // formRows
            // 
            formRows.BackColor = Color.FromArgb(22, 33, 62);
            formRows.ColumnCount = 1;
            formRows.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            formRows.Controls.Add(firstRow, 0, 0);
            formRows.Controls.Add(secondRow, 0, 1);
            formRows.Controls.Add(actions, 0, 2);
            formRows.Dock = DockStyle.Fill;
            formRows.Location = new Point(10, 10);
            formRows.Name = "formRows";
            formRows.RowCount = 3;
            formRows.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            formRows.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            formRows.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            formRows.Size = new Size(1166, 263);
            formRows.TabIndex = 0;
            // 
            // firstRow
            // 
            firstRow.BackColor = Color.FromArgb(22, 33, 62);
            firstRow.ColumnCount = 6;
            firstRow.ColumnStyles.Add(new ColumnStyle());
            firstRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            firstRow.ColumnStyles.Add(new ColumnStyle());
            firstRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            firstRow.ColumnStyles.Add(new ColumnStyle());
            firstRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            firstRow.Controls.Add(titleLabel, 0, 0);
            firstRow.Controls.Add(titleInput, 1, 0);
            firstRow.Controls.Add(dateLabel, 2, 0);
            firstRow.Controls.Add(eventDate, 3, 0);
            firstRow.Controls.Add(typeLabel, 4, 0);
            firstRow.Controls.Add(eventType, 5, 0);
            firstRow.Dock = DockStyle.Fill;
            firstRow.Location = new Point(3, 3);
            firstRow.Name = "firstRow";
            firstRow.RowCount = 1;
            firstRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            firstRow.Size = new Size(1160, 86);
            firstRow.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 8F);
            titleLabel.ForeColor = Color.FromArgb(150, 150, 170);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(28, 86);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titleInput
            // 
            titleInput.BackColor = Color.Transparent;
            titleInput.BorderColor = Color.FromArgb(233, 69, 96);
            titleInput.BorderRadius = 6;
            titleInput.Dock = DockStyle.Fill;
            titleInput.FillColor = Color.FromArgb(13, 17, 38);
            titleInput.FocusBorderColor = Color.FromArgb(233, 69, 96);
            titleInput.Font = new Font("Segoe UI", 9F);
            titleInput.ForeColor = Color.White;
            titleInput.Location = new Point(38, 4);
            titleInput.Margin = new Padding(4);
            titleInput.Name = "titleInput";
            titleInput.PlaceholderText = "Event title";
            titleInput.Size = new Size(434, 78);
            titleInput.TabIndex = 1;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Dock = DockStyle.Fill;
            dateLabel.Font = new Font("Segoe UI", 8F);
            dateLabel.ForeColor = Color.FromArgb(150, 150, 170);
            dateLabel.Location = new Point(479, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 86);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date";
            dateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eventDate
            // 
            eventDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eventDate.CalendarForeColor = Color.White;
            eventDate.CalendarMonthBackground = Color.FromArgb(22, 33, 62);
            eventDate.CalendarTitleBackColor = Color.FromArgb(233, 69, 96);
            eventDate.CalendarTitleForeColor = Color.White;
            eventDate.Font = new Font("Segoe UI", 9F);
            eventDate.Format = DateTimePickerFormat.Short;
            eventDate.Location = new Point(517, 31);
            eventDate.Margin = new Padding(4);
            eventDate.Name = "eventDate";
            eventDate.Size = new Size(244, 23);
            eventDate.TabIndex = 3;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Dock = DockStyle.Fill;
            typeLabel.Font = new Font("Segoe UI", 8F);
            typeLabel.ForeColor = Color.FromArgb(150, 150, 170);
            typeLabel.Location = new Point(768, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(29, 86);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "Type";
            typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eventType
            // 
            eventType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eventType.BackColor = Color.FromArgb(13, 17, 38);
            eventType.DropDownStyle = ComboBoxStyle.DropDownList;
            eventType.Font = new Font("Segoe UI", 9F);
            eventType.ForeColor = Color.White;
            eventType.Items.AddRange(new object[] { "Quiz", "Exam", "No Class", "Meeting", "Holiday", "Other" });
            eventType.Location = new Point(804, 31);
            eventType.Margin = new Padding(4);
            eventType.Name = "eventType";
            eventType.Size = new Size(352, 23);
            eventType.TabIndex = 5;
            // 
            // secondRow
            // 
            secondRow.BackColor = Color.FromArgb(22, 33, 62);
            secondRow.ColumnCount = 4;
            secondRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            secondRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            secondRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            secondRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            secondRow.Controls.Add(descriptionLabel, 0, 0);
            secondRow.Controls.Add(descriptionInput, 1, 0);
            secondRow.Controls.Add(courseLabel, 2, 0);
            secondRow.Controls.Add(coursePicker, 3, 0);
            secondRow.Dock = DockStyle.Fill;
            secondRow.Location = new Point(3, 95);
            secondRow.Name = "secondRow";
            secondRow.RowCount = 1;
            secondRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            secondRow.Size = new Size(1160, 86);
            secondRow.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Font = new Font("Segoe UI", 8F);
            descriptionLabel.ForeColor = Color.FromArgb(150, 150, 170);
            descriptionLabel.Location = new Point(3, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(86, 86);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionInput
            // 
            descriptionInput.BackColor = Color.Transparent;
            descriptionInput.BorderColor = Color.FromArgb(233, 69, 96);
            descriptionInput.BorderRadius = 6;
            descriptionInput.Dock = DockStyle.Fill;
            descriptionInput.FillColor = Color.FromArgb(13, 17, 38);
            descriptionInput.FocusBorderColor = Color.FromArgb(233, 69, 96);
            descriptionInput.Font = new Font("Segoe UI", 9F);
            descriptionInput.ForeColor = Color.White;
            descriptionInput.Location = new Point(96, 4);
            descriptionInput.Margin = new Padding(4);
            descriptionInput.Name = "descriptionInput";
            descriptionInput.PlaceholderText = "Optional event details";
            descriptionInput.Size = new Size(543, 78);
            descriptionInput.TabIndex = 1;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Dock = DockStyle.Fill;
            courseLabel.Font = new Font("Segoe UI", 8F);
            courseLabel.ForeColor = Color.FromArgb(150, 150, 170);
            courseLabel.Location = new Point(646, 0);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(112, 86);
            courseLabel.TabIndex = 2;
            courseLabel.Text = "Course (optional)";
            courseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // coursePicker
            // 
            coursePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            coursePicker.BackColor = Color.FromArgb(13, 17, 38);
            coursePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            coursePicker.Font = new Font("Segoe UI", 9F);
            coursePicker.ForeColor = Color.White;
            coursePicker.Location = new Point(765, 31);
            coursePicker.Margin = new Padding(4);
            coursePicker.Name = "coursePicker";
            coursePicker.Size = new Size(391, 23);
            coursePicker.TabIndex = 3;
            // 
            // actions
            // 
            actions.BackColor = Color.FromArgb(22, 33, 62);
            actions.Controls.Add(addButton);
            actions.Controls.Add(deleteButton);
            actions.Controls.Add(message);
            actions.Dock = DockStyle.Fill;
            actions.Location = new Point(3, 187);
            actions.Name = "actions";
            actions.Size = new Size(1160, 73);
            actions.TabIndex = 2;
            actions.WrapContents = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(233, 69, 96);
            addButton.BorderColor = Color.White;
            addButton.BorderRadius = 6;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.ForeColor = Color.White;
            addButton.HoverColor = Color.Empty;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.PressedColor = Color.Empty;
            addButton.Size = new Size(130, 34);
            addButton.TabIndex = 0;
            addButton.Text = "ADD EVENT";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(80, 30, 40);
            deleteButton.BorderColor = Color.White;
            deleteButton.BorderRadius = 6;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Enabled = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.ForeColor = Color.FromArgb(233, 69, 96);
            deleteButton.HoverColor = Color.Empty;
            deleteButton.Location = new Point(139, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.PressedColor = Color.Empty;
            deleteButton.Size = new Size(150, 34);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "DELETE SELECTED";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // message
            // 
            message.Font = new Font("Segoe UI", 8F);
            message.ForeColor = Color.FromArgb(150, 150, 170);
            message.Location = new Point(295, 0);
            message.Name = "message";
            message.Size = new Size(350, 34);
            message.TabIndex = 2;
            message.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legend
            // 
            legend.BackColor = Color.FromArgb(13, 17, 38);
            legend.Controls.Add(legendItem0);
            legend.Controls.Add(legendItem1);
            legend.Controls.Add(legendItem2);
            legend.Controls.Add(legendItem3);
            legend.Controls.Add(legendItem4);
            legend.Controls.Add(legendItem5);
            legend.Controls.Add(legendItem6);
            legend.Dock = DockStyle.Fill;
            legend.Location = new Point(7, 867);
            legend.Name = "legend";
            legend.Padding = new Padding(2, 4, 0, 0);
            legend.Size = new Size(1186, 26);
            legend.TabIndex = 3;
            legend.WrapContents = false;
            // 
            // legendItem0
            // 
            legendItem0.AutoSize = true;
            legendItem0.Controls.Add(legendSwatch0);
            legendItem0.Controls.Add(legendLabel0);
            legendItem0.Location = new Point(5, 4);
            legendItem0.Margin = new Padding(3, 0, 9, 0);
            legendItem0.Name = "legendItem0";
            legendItem0.Size = new Size(66, 14);
            legendItem0.TabIndex = 0;
            legendItem0.WrapContents = false;
            // 
            // legendSwatch0
            // 
            legendSwatch0.BackColor = Color.FromArgb(204, 34, 68);
            legendSwatch0.Location = new Point(0, 4);
            legendSwatch0.Margin = new Padding(0, 4, 4, 0);
            legendSwatch0.Name = "legendSwatch0";
            legendSwatch0.Size = new Size(10, 10);
            legendSwatch0.TabIndex = 0;
            // 
            // legendLabel0
            // 
            legendLabel0.AutoSize = true;
            legendLabel0.Font = new Font("Segoe UI", 8F);
            legendLabel0.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel0.Location = new Point(17, 0);
            legendLabel0.Name = "legendLabel0";
            legendLabel0.Size = new Size(46, 13);
            legendLabel0.TabIndex = 1;
            legendLabel0.Text = "Holiday";
            legendLabel0.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legendItem1
            // 
            legendItem1.AutoSize = true;
            legendItem1.Controls.Add(legendSwatch1);
            legendItem1.Controls.Add(legendLabel1);
            legendItem1.Location = new Point(83, 4);
            legendItem1.Margin = new Padding(3, 0, 9, 0);
            legendItem1.Name = "legendItem1";
            legendItem1.Size = new Size(53, 14);
            legendItem1.TabIndex = 1;
            legendItem1.WrapContents = false;
            // 
            // legendSwatch1
            // 
            legendSwatch1.BackColor = Color.FromArgb(106, 13, 173);
            legendSwatch1.Location = new Point(0, 4);
            legendSwatch1.Margin = new Padding(0, 4, 4, 0);
            legendSwatch1.Name = "legendSwatch1";
            legendSwatch1.Size = new Size(10, 10);
            legendSwatch1.TabIndex = 0;
            // 
            // legendLabel1
            // 
            legendLabel1.AutoSize = true;
            legendLabel1.Font = new Font("Segoe UI", 8F);
            legendLabel1.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel1.Location = new Point(17, 0);
            legendLabel1.Name = "legendLabel1";
            legendLabel1.Size = new Size(33, 13);
            legendLabel1.TabIndex = 1;
            legendLabel1.Text = "Exam";
            legendLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legendItem2
            // 
            legendItem2.AutoSize = true;
            legendItem2.Controls.Add(legendSwatch2);
            legendItem2.Controls.Add(legendLabel2);
            legendItem2.Location = new Point(148, 4);
            legendItem2.Margin = new Padding(3, 0, 9, 0);
            legendItem2.Name = "legendItem2";
            legendItem2.Size = new Size(50, 14);
            legendItem2.TabIndex = 2;
            legendItem2.WrapContents = false;
            // 
            // legendSwatch2
            // 
            legendSwatch2.BackColor = Color.FromArgb(0, 102, 204);
            legendSwatch2.Location = new Point(0, 4);
            legendSwatch2.Margin = new Padding(0, 4, 4, 0);
            legendSwatch2.Name = "legendSwatch2";
            legendSwatch2.Size = new Size(10, 10);
            legendSwatch2.TabIndex = 0;
            // 
            // legendLabel2
            // 
            legendLabel2.AutoSize = true;
            legendLabel2.Font = new Font("Segoe UI", 8F);
            legendLabel2.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel2.Location = new Point(17, 0);
            legendLabel2.Name = "legendLabel2";
            legendLabel2.Size = new Size(30, 13);
            legendLabel2.TabIndex = 1;
            legendLabel2.Text = "Quiz";
            legendLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legendItem3
            // 
            legendItem3.AutoSize = true;
            legendItem3.Controls.Add(legendSwatch3);
            legendItem3.Controls.Add(legendLabel3);
            legendItem3.Location = new Point(210, 4);
            legendItem3.Margin = new Padding(3, 0, 9, 0);
            legendItem3.Name = "legendItem3";
            legendItem3.Size = new Size(71, 14);
            legendItem3.TabIndex = 3;
            legendItem3.WrapContents = false;
            // 
            // legendSwatch3
            // 
            legendSwatch3.BackColor = Color.FromArgb(204, 136, 0);
            legendSwatch3.Location = new Point(0, 4);
            legendSwatch3.Margin = new Padding(0, 4, 4, 0);
            legendSwatch3.Name = "legendSwatch3";
            legendSwatch3.Size = new Size(10, 10);
            legendSwatch3.TabIndex = 0;
            // 
            // legendLabel3
            // 
            legendLabel3.AutoSize = true;
            legendLabel3.Font = new Font("Segoe UI", 8F);
            legendLabel3.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel3.Location = new Point(17, 0);
            legendLabel3.Name = "legendLabel3";
            legendLabel3.Size = new Size(51, 13);
            legendLabel3.TabIndex = 1;
            legendLabel3.Text = "No Class";
            legendLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legendItem4
            // 
            legendItem4.AutoSize = true;
            legendItem4.Controls.Add(legendSwatch4);
            legendItem4.Controls.Add(legendLabel4);
            legendItem4.Location = new Point(293, 4);
            legendItem4.Margin = new Padding(3, 0, 9, 0);
            legendItem4.Name = "legendItem4";
            legendItem4.Size = new Size(70, 14);
            legendItem4.TabIndex = 4;
            legendItem4.WrapContents = false;
            // 
            // legendSwatch4
            // 
            legendSwatch4.BackColor = Color.FromArgb(0, 119, 68);
            legendSwatch4.Location = new Point(0, 4);
            legendSwatch4.Margin = new Padding(0, 4, 4, 0);
            legendSwatch4.Name = "legendSwatch4";
            legendSwatch4.Size = new Size(10, 10);
            legendSwatch4.TabIndex = 0;
            // 
            // legendLabel4
            // 
            legendLabel4.AutoSize = true;
            legendLabel4.Font = new Font("Segoe UI", 8F);
            legendLabel4.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel4.Location = new Point(17, 0);
            legendLabel4.Name = "legendLabel4";
            legendLabel4.Size = new Size(50, 13);
            legendLabel4.TabIndex = 1;
            legendLabel4.Text = "Meeting";
            legendLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legendItem5
            // 
            legendItem5.AutoSize = true;
            legendItem5.Controls.Add(legendSwatch5);
            legendItem5.Controls.Add(legendLabel5);
            legendItem5.Location = new Point(375, 4);
            legendItem5.Margin = new Padding(3, 0, 9, 0);
            legendItem5.Name = "legendItem5";
            legendItem5.Size = new Size(55, 14);
            legendItem5.TabIndex = 5;
            legendItem5.WrapContents = false;
            // 
            // legendSwatch5
            // 
            legendSwatch5.BackColor = Color.FromArgb(68, 68, 102);
            legendSwatch5.Location = new Point(0, 4);
            legendSwatch5.Margin = new Padding(0, 4, 4, 0);
            legendSwatch5.Name = "legendSwatch5";
            legendSwatch5.Size = new Size(10, 10);
            legendSwatch5.TabIndex = 0;
            // 
            // legendLabel5
            // 
            legendLabel5.AutoSize = true;
            legendLabel5.Font = new Font("Segoe UI", 8F);
            legendLabel5.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel5.Location = new Point(17, 0);
            legendLabel5.Name = "legendLabel5";
            legendLabel5.Size = new Size(35, 13);
            legendLabel5.TabIndex = 1;
            legendLabel5.Text = "Event";
            legendLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // legendItem6
            // 
            legendItem6.AutoSize = true;
            legendItem6.Controls.Add(legendSwatch6);
            legendItem6.Controls.Add(legendLabel6);
            legendItem6.Location = new Point(442, 4);
            legendItem6.Margin = new Padding(3, 0, 9, 0);
            legendItem6.Name = "legendItem6";
            legendItem6.Size = new Size(57, 14);
            legendItem6.TabIndex = 6;
            legendItem6.WrapContents = false;
            // 
            // legendSwatch6
            // 
            legendSwatch6.BackColor = Color.FromArgb(68, 68, 102);
            legendSwatch6.Location = new Point(0, 4);
            legendSwatch6.Margin = new Padding(0, 4, 4, 0);
            legendSwatch6.Name = "legendSwatch6";
            legendSwatch6.Size = new Size(10, 10);
            legendSwatch6.TabIndex = 0;
            // 
            // legendLabel6
            // 
            legendLabel6.AutoSize = true;
            legendLabel6.Font = new Font("Segoe UI", 8F);
            legendLabel6.ForeColor = Color.FromArgb(150, 150, 170);
            legendLabel6.Location = new Point(17, 0);
            legendLabel6.Name = "legendLabel6";
            legendLabel6.Size = new Size(37, 13);
            legendLabel6.TabIndex = 1;
            legendLabel6.Text = "Other";
            legendLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InstructorCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 38);
            Controls.Add(root);
            Font = new Font("Segoe UI", 9F);
            Name = "InstructorCalendar";
            Size = new Size(1200, 900);
            Load += InstructorCalendar_Load;
            root.ResumeLayout(false);
            header.ResumeLayout(false);
            calendarGrid.ResumeLayout(false);
            dayCell00.ResumeLayout(false);
            dayEvents00.ResumeLayout(false);
            dayCell01.ResumeLayout(false);
            dayEvents01.ResumeLayout(false);
            dayCell02.ResumeLayout(false);
            dayEvents02.ResumeLayout(false);
            dayCell03.ResumeLayout(false);
            dayEvents03.ResumeLayout(false);
            dayCell04.ResumeLayout(false);
            dayEvents04.ResumeLayout(false);
            dayCell05.ResumeLayout(false);
            dayEvents05.ResumeLayout(false);
            dayCell06.ResumeLayout(false);
            dayEvents06.ResumeLayout(false);
            dayCell07.ResumeLayout(false);
            dayEvents07.ResumeLayout(false);
            dayCell08.ResumeLayout(false);
            dayEvents08.ResumeLayout(false);
            dayCell09.ResumeLayout(false);
            dayEvents09.ResumeLayout(false);
            dayCell10.ResumeLayout(false);
            dayEvents10.ResumeLayout(false);
            dayCell11.ResumeLayout(false);
            dayEvents11.ResumeLayout(false);
            dayCell12.ResumeLayout(false);
            dayEvents12.ResumeLayout(false);
            dayCell13.ResumeLayout(false);
            dayEvents13.ResumeLayout(false);
            dayCell14.ResumeLayout(false);
            dayEvents14.ResumeLayout(false);
            dayCell15.ResumeLayout(false);
            dayEvents15.ResumeLayout(false);
            dayCell16.ResumeLayout(false);
            dayEvents16.ResumeLayout(false);
            dayCell17.ResumeLayout(false);
            dayEvents17.ResumeLayout(false);
            dayCell18.ResumeLayout(false);
            dayEvents18.ResumeLayout(false);
            dayCell19.ResumeLayout(false);
            dayEvents19.ResumeLayout(false);
            dayCell20.ResumeLayout(false);
            dayEvents20.ResumeLayout(false);
            dayCell21.ResumeLayout(false);
            dayEvents21.ResumeLayout(false);
            dayCell22.ResumeLayout(false);
            dayEvents22.ResumeLayout(false);
            dayCell23.ResumeLayout(false);
            dayEvents23.ResumeLayout(false);
            dayCell24.ResumeLayout(false);
            dayEvents24.ResumeLayout(false);
            dayCell25.ResumeLayout(false);
            dayEvents25.ResumeLayout(false);
            dayCell26.ResumeLayout(false);
            dayEvents26.ResumeLayout(false);
            dayCell27.ResumeLayout(false);
            dayEvents27.ResumeLayout(false);
            dayCell28.ResumeLayout(false);
            dayEvents28.ResumeLayout(false);
            dayCell29.ResumeLayout(false);
            dayEvents29.ResumeLayout(false);
            dayCell30.ResumeLayout(false);
            dayEvents30.ResumeLayout(false);
            dayCell31.ResumeLayout(false);
            dayEvents31.ResumeLayout(false);
            dayCell32.ResumeLayout(false);
            dayEvents32.ResumeLayout(false);
            dayCell33.ResumeLayout(false);
            dayEvents33.ResumeLayout(false);
            dayCell34.ResumeLayout(false);
            dayEvents34.ResumeLayout(false);
            dayCell35.ResumeLayout(false);
            dayEvents35.ResumeLayout(false);
            dayCell36.ResumeLayout(false);
            dayEvents36.ResumeLayout(false);
            dayCell37.ResumeLayout(false);
            dayEvents37.ResumeLayout(false);
            dayCell38.ResumeLayout(false);
            dayEvents38.ResumeLayout(false);
            dayCell39.ResumeLayout(false);
            dayEvents39.ResumeLayout(false);
            dayCell40.ResumeLayout(false);
            dayEvents40.ResumeLayout(false);
            dayCell41.ResumeLayout(false);
            dayEvents41.ResumeLayout(false);
            eventCard.ResumeLayout(false);
            formRows.ResumeLayout(false);
            firstRow.ResumeLayout(false);
            firstRow.PerformLayout();
            secondRow.ResumeLayout(false);
            secondRow.PerformLayout();
            actions.ResumeLayout(false);
            legend.ResumeLayout(false);
            legend.PerformLayout();
            legendItem0.ResumeLayout(false);
            legendItem0.PerformLayout();
            legendItem1.ResumeLayout(false);
            legendItem1.PerformLayout();
            legendItem2.ResumeLayout(false);
            legendItem2.PerformLayout();
            legendItem3.ResumeLayout(false);
            legendItem3.PerformLayout();
            legendItem4.ResumeLayout(false);
            legendItem4.PerformLayout();
            legendItem5.ResumeLayout(false);
            legendItem5.PerformLayout();
            legendItem6.ResumeLayout(false);
            legendItem6.PerformLayout();
            ResumeLayout(false);
        }
    }
}
