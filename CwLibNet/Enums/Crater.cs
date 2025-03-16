using System.Numerics;
using static CwLibNet.IO.ValueEnum<int>;

namespace CwLibNet.Enums
{
    public enum Crater : int
    {
        // SLOT_0_LBP1(0.31077105f, -0.83225715f, -0.45909613f)
        SLOT_0_LBP1,
        // SLOT_1_LBP1(0.4628601f, 0.86776716f, 0.18094404f)
        SLOT_1_LBP1,
        // SLOT_2_LBP1(0.7486169f, 0.60400087f, 0.27341494f)
        SLOT_2_LBP1,
        // SLOT_3_LBP1(0.39563915f, -0.8774683f, -0.2711441f)
        SLOT_3_LBP1,
        // SLOT_4_LBP1(0.20288597f, -0.9144148f, -0.35026094f)
        SLOT_4_LBP1,
        // SLOT_5_LBP1(0.25761792f, -0.9545006f, -0.15020494f)
        SLOT_5_LBP1,
        // SLOT_6_LBP1(0.4088082f, -0.9105484f, -0.06146103f)
        SLOT_6_LBP1,
        // SLOT_7_LBP1(0.5479258f, -0.82450265f, -0.14132494f)
        SLOT_7_LBP1,
        // SLOT_8_LBP1(0.5672089f, -0.7657998f, -0.30302593f)
        SLOT_8_LBP1,
        // SLOT_9_LBP1(-0.172129f, -0.322175f, 0.9309f)
        SLOT_9_LBP1,
        // SLOT_10_LBP1(-0.05300901f, -0.17990205f, 0.9822552f)
        SLOT_10_LBP1,
        // SLOT_11_LBP1(-0.09783502f, 0.025761006f, 0.99486923f)
        SLOT_11_LBP1,
        // SLOT_12_LBP1(-0.4167152f, -0.06320103f, -0.9068374f)
        SLOT_12_LBP1,
        // SLOT_13_LBP1(-0.26614404f, 0.79785514f, -0.5409201f)
        SLOT_13_LBP1,
        // SLOT_14_LBP1(-0.07221399f, 0.83258086f, -0.5491759f)
        SLOT_14_LBP1,
        // SLOT_15_LBP1(0.8303515f, 0.5512984f, -0.08115804f)
        SLOT_15_LBP1,
        // SLOT_16_LBP1(0.6335288f, 0.7239608f, -0.27298695f)
        SLOT_16_LBP1,
        // SLOT_17_LBP1(0.754212f, 0.614567f, -0.231239f)
        SLOT_17_LBP1,
        // SLOT_18_LBP1(0.50869703f, 0.8305341f, -0.22680503f)
        SLOT_18_LBP1,
        // SLOT_19_LBP1(0.47776696f, 0.87838393f, -0.013427999f)
        SLOT_19_LBP1,
        // SLOT_20_LBP1(0.62219197f, 0.75183296f, 0.21822998f)
        SLOT_20_LBP1,
        // SLOT_21_LBP1(0.8079443f, 0.5790812f, 0.109046035f)
        SLOT_21_LBP1,
        // SLOT_22_LBP1(0.35630608f, 0.3279511f, 0.8749252f)
        SLOT_22_LBP1,
        // SLOT_23_LBP1(0.512454f, 0.366131f, 0.776749f)
        SLOT_23_LBP1,
        // SLOT_24_LBP1(0.98978335f, -0.14198504f, 0.013014005f)
        SLOT_24_LBP1,
        // SLOT_25_LBP1(0.99952567f, -0.023080993f, 0.020388993f)
        SLOT_25_LBP1,
        // SLOT_26_LBP1(0.9697515f, -0.2230121f, 0.09923604f)
        SLOT_26_LBP1,
        // SLOT_27_LBP1(0.98948795f, 0.023391997f, 0.14271098f)
        SLOT_27_LBP1,
        // SLOT_28_LBP1(0.965258f, -0.047163f, 0.257007f)
        SLOT_28_LBP1,
        // SLOT_29_LBP1(0.6841198f, 0.72766775f, -0.049796984f)
        SLOT_29_LBP1,
        // SLOT_30_LBP1(-0.55120695f, -0.33277997f, -0.7651329f)
        SLOT_30_LBP1,
        // SLOT_31_LBP1(0.3719329f, 0.50006884f, 0.7820467f)
        SLOT_31_LBP1,
        // SLOT_32_LBP1(-0.38784105f, -0.21594504f, -0.8960731f)
        SLOT_32_LBP1,
        // SLOT_33_LBP1(-0.4184162f, -0.49700522f, -0.76020634f)
        SLOT_33_LBP1,
        // SLOT_34_LBP1(-0.261681f, -0.104449f, -0.959486f)
        SLOT_34_LBP1,
        // SLOT_35_LBP1(-0.26347908f, 0.8988393f, 0.3502381f)
        SLOT_35_LBP1,
        // SLOT_36_LBP1(-0.05115603f, 0.7022214f, -0.7101184f)
        SLOT_36_LBP1,
        // SLOT_37_LBP1(-0.021189002f, -0.70984006f, 0.70404404f)
        SLOT_37_LBP1,
        // SLOT_38_LBP1(-0.7321999f, 0.41059193f, 0.54341286f)
        SLOT_38_LBP1,
        // SLOT_39_LBP1(0.8426612f, -0.19560504f, -0.50165814f)
        SLOT_39_LBP1,
        // SLOT_40_LBP1(-0.24126509f, -0.2668241f, -0.93305737f)
        SLOT_40_LBP1,
        // SLOT_41_LBP1(0.7592101f, -0.010854001f, 0.65075505f)
        SLOT_41_LBP1,
        // SLOT_42_LBP1(-0.9484006f, -0.20853193f, -0.2388529f)
        SLOT_42_LBP1,
        // SLOT_43_LBP1(-0.9016544f, -0.39435717f, -0.17748709f)
        SLOT_43_LBP1,
        // SLOT_44_LBP1(-0.8763887f, -0.40167686f, -0.26570392f)
        SLOT_44_LBP1,
        // SLOT_45_LBP1(-0.93659484f, -0.32658395f, -0.12701596f)
        SLOT_45_LBP1,
        // SLOT_46_LBP1(-0.92078555f, -0.31372318f, -0.23180114f)
        SLOT_46_LBP1,
        // SLOT_47_LBP1(-0.8799429f, -0.34116998f, -0.33061096f)
        SLOT_47_LBP1,
        // SLOT_48_LBP1(-0.91347873f, -0.25022894f, -0.3208459f)
        SLOT_48_LBP1,
        // SLOT_49_LBP1(-0.95822436f, -0.24382709f, -0.14951406f)
        SLOT_49_LBP1,
        // SLOT_50_LBP1(0.4321622f, -0.37104517f, -0.8219254f)
        SLOT_50_LBP1,
        // SLOT_51_LBP1(-0.23641692f, 0.6839048f, -0.69020385f)
        SLOT_51_LBP1,
        // SLOT_52_LBP1(-0.6752077f, -0.6518117f, -0.34530583f)
        SLOT_52_LBP1,
        // SLOT_53_LBP1(-0.8629373f, 0.5012612f, -0.06384702f)
        SLOT_53_LBP1,
        // SLOT_54_LBP1(-0.41883606f, -0.85028714f, 0.31872904f)
        SLOT_54_LBP1,
        // SLOT_55_LBP1(-0.027164994f, 0.6557988f, 0.7544468f)
        SLOT_55_LBP1,
        // SLOT_56_LBP1(-0.5452938f, -0.13882895f, -0.82666874f)
        SLOT_56_LBP1,
        // SLOT_57_LBP1(0.61655706f, 0.18021101f, -0.76640815f)
        SLOT_57_LBP1,
        // SLOT_58_LBP1(0.17522402f, -0.8983221f, 0.40288207f)
        SLOT_58_LBP1,
        // SLOT_59_LBP1(-0.32325393f, -0.12421998f, 0.9381238f)
        SLOT_59_LBP1,
        // SLOT_60_LBP1(0.95858824f, -0.18041405f, 0.22036205f)
        SLOT_60_LBP1,
        // SLOT_61_LBP1(0.84370273f, 0.2576859f, -0.47091785f)
        SLOT_61_LBP1,
        // SLOT_62_LBP1(0.86589384f, 0.25325894f, 0.4313789f)
        SLOT_62_LBP1,
        // SLOT_63_LBP1(0.24578999f, 0.36295098f, -0.8988069f)
        SLOT_63_LBP1,
        // SLOT_64_LBP1(0.46892294f, -0.76497185f, -0.44150794f)
        SLOT_64_LBP1,
        // SLOT_65_LBP1(-0.3769459f, -0.3602679f, -0.85329884f)
        SLOT_65_LBP1,
        // SLOT_66_LBP1(0.11805903f, 0.3125141f, -0.9425482f)
        SLOT_66_LBP1,
        // SLOT_67_LBP1(0.24369888f, 0.2274599f, -0.9428005f)
        SLOT_67_LBP1,
        // SLOT_68_LBP1(-0.20356704f, -0.44608912f, -0.8715302f)
        SLOT_68_LBP1,
        // SLOT_69_LBP1(-0.82691664f, -0.26985687f, 0.4933418f)
        SLOT_69_LBP1,
        // SLOT_70_LBP1(-0.76749134f, -0.24230312f, 0.5935033f)
        SLOT_70_LBP1,
        // SLOT_71_LBP1(-0.80561f, -0.125551f, 0.57899f)
        SLOT_71_LBP1,
        // SLOT_72_LBP1(-0.8650643f, -0.15859807f, 0.47593117f)
        SLOT_72_LBP1,
        // SLOT_73_LBP1(-0.5884999f, -0.7519028f, 0.29716995f)
        SLOT_73_LBP1,
        // SLOT_74_LBP1(-0.47690418f, -0.8752783f, 0.08031403f)
        SLOT_74_LBP1,
        // SLOT_75_LBP1(-0.60155725f, -0.7851503f, 0.14720006f)
        SLOT_75_LBP1,
        // SLOT_76_LBP1(-0.34879893f, -0.9241368f, 0.15591797f)
        SLOT_76_LBP1,
        // SLOT_77_LBP1(-0.8888866f, 0.30699086f, -0.34005484f)
        SLOT_77_LBP1,
        // SLOT_78_LBP1(-0.8180849f, 0.51174086f, -0.26240894f)
        SLOT_78_LBP1,
        // SLOT_79_LBP1(-0.94460547f, 0.32007915f, -0.07259504f)
        SLOT_79_LBP1,
        // SLOT_80_LBP1(-0.956602f, 0.193788f, -0.217621f)
        SLOT_80_LBP1,
        // SLOT_81_LBP1(0.5242757f, -0.5701827f, 0.6324766f)
        SLOT_81_LBP1,
        // SLOT_0_LBP3(0.22778413f, -0.8169135f, -0.5298743f)
        SLOT_0_LBP3,
        // SLOT_1_LBP3(0.4678959f, 0.87881374f, 0.09359398f)
        SLOT_1_LBP3,
        // SLOT_2_LBP3(0.777997f, 0.610497f, 0.148371f)
        SLOT_2_LBP3,
        // SLOT_3_LBP3(0.3390612f, -0.8742445f, -0.3474682f)
        SLOT_3_LBP3,
        // SLOT_4_LBP3(0.12523201f, -0.9050611f, -0.40642506f)
        SLOT_4_LBP3,
        // SLOT_5_LBP3(0.17382409f, -0.95636547f, -0.23484112f)
        SLOT_5_LBP3,
        // SLOT_6_LBP3(0.37352908f, -0.91859126f, -0.12909803f)
        SLOT_6_LBP3,
        // SLOT_7_LBP3(0.5248221f, -0.8119892f, -0.25541207f)
        SLOT_7_LBP3,
        // SLOT_8_LBP3(0.5248129f, -0.74482983f, -0.41206792f)
        SLOT_8_LBP3,
        // SLOT_9_LBP3(-0.041708987f, -0.32910192f, 0.9433728f)
        SLOT_9_LBP3,
        // SLOT_10_LBP3(0.11623898f, -0.19960797f, 0.9729569f)
        SLOT_10_LBP3,
        // SLOT_11_LBP3(0.053192973f, 0.025618987f, 0.99825555f)
        SLOT_11_LBP3,
        // SLOT_12_LBP3(-0.5848139f, -0.03537499f, -0.81039584f)
        SLOT_12_LBP3,
        // SLOT_13_LBP3(-0.29595807f, 0.92773426f, -0.22741605f)
        SLOT_13_LBP3,
        // SLOT_14_LBP3(-0.09560399f, 0.9576028f, -0.27176595f)
        SLOT_14_LBP3,
        // SLOT_15_LBP3(0.8138356f, 0.53664476f, -0.22289892f)
        SLOT_15_LBP3,
        // SLOT_16_LBP3(0.58721685f, 0.7002269f, -0.40602794f)
        SLOT_16_LBP3,
        // SLOT_17_LBP3(0.7134027f, 0.60602474f, -0.35183886f)
        SLOT_17_LBP3,
        // SLOT_18_LBP3(0.4924268f, 0.8124397f, -0.3121819f)
        SLOT_18_LBP3,
        // SLOT_19_LBP3(0.46152917f, 0.8812123f, -0.102253035f)
        SLOT_19_LBP3,
        // SLOT_20_LBP3(0.64410996f, 0.7576859f, 0.10504498f)
        SLOT_20_LBP3,
        // SLOT_21_LBP3(0.813017f, 0.58145f, -0.030317f)
        SLOT_21_LBP3,
        // SLOT_22_LBP3(0.4763743f, 0.3434002f, 0.8094095f)
        SLOT_22_LBP3,
        // SLOT_23_LBP3(0.62834f, 0.34902f, 0.695251f)
        SLOT_23_LBP3,
        // SLOT_24_LBP3(0.9767195f, -0.14132607f, -0.16138807f)
        SLOT_24_LBP3,
        // SLOT_25_LBP3(0.98970294f, -0.018697998f, -0.14190999f)
        SLOT_25_LBP3,
        // SLOT_26_LBP3(0.96940535f, -0.2348231f, -0.07149502f)
        SLOT_26_LBP3,
        // SLOT_27_LBP3(0.9994955f, 0.025358012f, -0.019124009f)
        SLOT_27_LBP3,
        // SLOT_28_LBP3(0.99357015f, -0.06181501f, 0.09485401f)
        SLOT_28_LBP3,
        // SLOT_29_LBP3(0.6593018f, 0.73002976f, -0.17993794f)
        SLOT_29_LBP3,
        // SLOT_30_LBP3(-0.69867504f, -0.32301602f, -0.63836807f)
        SLOT_30_LBP3,
        // SLOT_31_LBP3(0.51312673f, 0.5000767f, 0.69758457f)
        SLOT_31_LBP3,
        // SLOT_32_LBP3(-0.55164087f, -0.21482195f, -0.8059429f)
        SLOT_32_LBP3,
        // SLOT_33_LBP3(-0.56181186f, -0.49182987f, -0.6651848f)
        SLOT_33_LBP3,
        // SLOT_34_LBP3(-0.4477672f, -0.08849304f, -0.88976043f)
        SLOT_34_LBP3,
        // SLOT_35_LBP3(-0.20835088f, 0.8911815f, 0.4029708f)
        SLOT_35_LBP3,
        // SLOT_36_LBP3(-0.11301704f, 0.8784243f, -0.4643252f)
        SLOT_36_LBP3,
        // SLOT_37_LBP3(0.08895204f, -0.7097124f, 0.6988534f)
        SLOT_37_LBP3,
        // SLOT_38_LBP3(-0.9445418f, -0.050015993f, 0.32455993f)
        SLOT_38_LBP3,
        // SLOT_39_LBP3(0.74562633f, -0.1843541f, -0.6403553f)
        SLOT_39_LBP3,
        // SLOT_40_LBP3(-0.31536397f, -0.19392496f, -0.9289449f)
        SLOT_40_LBP3,
        // SLOT_41_LBP3(0.85473895f, -0.010594999f, 0.5189499f)
        SLOT_41_LBP3,
        // SLOT_42_LBP3(-0.9766321f, -0.20016304f, -0.078259006f)
        SLOT_42_LBP3,
        // SLOT_43_LBP3(-0.9172905f, -0.39529023f, -0.04820503f)
        SLOT_43_LBP3,
        // SLOT_44_LBP3(-0.91303694f, -0.38422298f, -0.13687998f)
        SLOT_44_LBP3,
        // SLOT_45_LBP3(-0.9418622f, -0.33555508f, 0.017276004f)
        SLOT_45_LBP3,
        // SLOT_46_LBP3(-0.9491289f, -0.30334398f, -0.08447899f)
        SLOT_46_LBP3,
        // SLOT_47_LBP3(-0.92981476f, -0.31520292f, -0.18997796f)
        SLOT_47_LBP3,
        // SLOT_48_LBP3(-0.95851827f, -0.23114106f, -0.16678305f)
        SLOT_48_LBP3,
        // SLOT_49_LBP3(-0.9693676f, -0.2455579f, 0.005259998f)
        SLOT_49_LBP3,
        // SLOT_50_LBP3(0.28622508f, -0.36067012f, -0.8876893f)
        SLOT_50_LBP3,
        // SLOT_51_LBP3(-0.316601f, 0.852023f, -0.416918f)
        SLOT_51_LBP3,
        // SLOT_52_LBP3(-0.7317929f, -0.6429439f, -0.22605798f)
        SLOT_52_LBP3,
        // SLOT_53_LBP3(-0.8620861f, 0.50048107f, 0.07953801f)
        SLOT_53_LBP3,
        // SLOT_54_LBP3(-0.35759908f, -0.8473742f, 0.39253008f)
        SLOT_54_LBP3,
        // SLOT_55_LBP3(0.09271405f, 0.6559274f, 0.74910843f)
        SLOT_55_LBP3,
        // SLOT_56_LBP3(-0.690833f, -0.132761f, -0.710721f)
        SLOT_56_LBP3,
        // SLOT_57_LBP3(0.48501617f, 0.19240208f, -0.8530773f)
        SLOT_57_LBP3,
        // SLOT_58_LBP3(0.23542188f, -0.9010166f, 0.3643428f)
        SLOT_58_LBP3,
        // SLOT_59_LBP3(-0.18722709f, -0.12533206f, 0.97428846f)
        SLOT_59_LBP3,
        // SLOT_60_LBP3(0.97940934f, -0.19448908f, 0.05414302f)
        SLOT_60_LBP3,
        // SLOT_61_LBP3(0.7533981f, 0.26474202f, -0.6019161f)
        SLOT_61_LBP3,
        // SLOT_62_LBP3(0.9250968f, 0.25169894f, 0.28432995f)
        SLOT_62_LBP3,
        // SLOT_63_LBP3(-0.54199266f, 0.41537574f, -0.7305525f)
        SLOT_63_LBP3,
        // SLOT_64_LBP3(0.39728823f, -0.7529645f, -0.5246013f)
        SLOT_64_LBP3,
        // SLOT_65_LBP3(-0.48730212f, -0.3744961f, -0.78885317f)
        SLOT_65_LBP3,
        // SLOT_66_LBP3(-0.4388629f, 0.5225128f, -0.73101276f)
        SLOT_66_LBP3,
        // SLOT_67_LBP3(-0.5598222f, 0.5301392f, -0.63682926f)
        SLOT_67_LBP3,
        // SLOT_68_LBP3(-0.3145371f, -0.38218415f, -0.8689083f)
        SLOT_68_LBP3,
        // SLOT_69_LBP3(-0.75691617f, -0.24991706f, 0.60383713f)
        SLOT_69_LBP3,
        // SLOT_70_LBP3(-0.6758379f, -0.25107795f, 0.6929669f)
        SLOT_70_LBP3,
        // SLOT_71_LBP3(-0.6971328f, -0.13262197f, 0.7045688f)
        SLOT_71_LBP3,
        // SLOT_72_LBP3(-0.7775172f, -0.13172904f, 0.6149101f)
        SLOT_72_LBP3,
        // SLOT_73_LBP3(-0.5378789f, -0.74035084f, 0.40319592f)
        SLOT_73_LBP3,
        // SLOT_74_LBP3(-0.4347799f, -0.88440377f, 0.16969496f)
        SLOT_74_LBP3,
        // SLOT_75_LBP3(-0.5762558f, -0.7797927f, 0.2446479f)
        SLOT_75_LBP3,
        // SLOT_76_LBP3(-0.2941059f, -0.9257966f, 0.23749189f)
        SLOT_76_LBP3,
        // SLOT_77_LBP3(-0.9226437f, 0.3269559f, -0.20451994f)
        SLOT_77_LBP3,
        // SLOT_78_LBP3(-0.844277f, 0.521593f, -0.123033f)
        SLOT_78_LBP3,
        // SLOT_79_LBP3(-0.94591147f, 0.31479314f, 0.078466035f)
        SLOT_79_LBP3,
        // SLOT_80_LBP3(-0.97560966f, 0.20564793f, -0.076776974f)
        SLOT_80_LBP3,
        // SLOT_81_LBP3(0.83252716f, -0.5501321f, 0.06521601f)
        SLOT_81_LBP3
    }
    public static class CraterExtensions
    {
        private static readonly Dictionary<Crater, Vector4> _values = new()
        {
            { Crater.SLOT_0_LBP1, new Vector4(0.31077105f, -0.83225715f, -0.45909613f, 0) },
            { Crater.SLOT_1_LBP1, new Vector4(0.4628601f, 0.86776716f, 0.18094404f, 0) },
            { Crater.SLOT_2_LBP1, new Vector4(0.7486169f, 0.60400087f, 0.27341494f, 0) },
            { Crater.SLOT_3_LBP1, new Vector4(0.39563915f, -0.8774683f, -0.2711441f, 0) },
            { Crater.SLOT_4_LBP1, new Vector4(0.20288597f, -0.9144148f, -0.35026094f, 0) },
            { Crater.SLOT_5_LBP1, new Vector4(0.25761792f, -0.9545006f, -0.15020494f, 0) },
            { Crater.SLOT_6_LBP1, new Vector4(0.4088082f, -0.9105484f, -0.06146103f, 0) },
            { Crater.SLOT_7_LBP1, new Vector4(0.5479258f, -0.82450265f, -0.14132494f, 0) },
            { Crater.SLOT_8_LBP1, new Vector4(0.5672089f, -0.7657998f, -0.30302593f, 0) },
            { Crater.SLOT_9_LBP1, new Vector4(-0.172129f, -0.322175f, 0.9309f, 0) },
            { Crater.SLOT_10_LBP1, new Vector4(-0.05300901f, -0.17990205f, 0.9822552f, 0) },
            { Crater.SLOT_11_LBP1, new Vector4(-0.09783502f, 0.025761006f, 0.99486923f, 0) },
            { Crater.SLOT_12_LBP1, new Vector4(-0.4167152f, -0.06320103f, -0.9068374f, 0) },
            { Crater.SLOT_13_LBP1, new Vector4(-0.26614404f, 0.79785514f, -0.5409201f, 0) },
            { Crater.SLOT_14_LBP1, new Vector4(-0.07221399f, 0.83258086f, -0.5491759f, 0) },
            { Crater.SLOT_15_LBP1, new Vector4(0.8303515f, 0.5512984f, -0.08115804f, 0) },
            { Crater.SLOT_16_LBP1, new Vector4(0.6335288f, 0.7239608f, -0.27298695f, 0) },
            { Crater.SLOT_17_LBP1, new Vector4(0.754212f, 0.614567f, -0.231239f, 0) },
            { Crater.SLOT_18_LBP1, new Vector4(0.50869703f, 0.8305341f, -0.22680503f, 0) },
            { Crater.SLOT_19_LBP1, new Vector4(0.47776696f, 0.87838393f, -0.013427999f, 0) },
            { Crater.SLOT_20_LBP1, new Vector4(0.62219197f, 0.75183296f, 0.21822998f, 0) },
            { Crater.SLOT_21_LBP1, new Vector4(0.8079443f, 0.5790812f, 0.109046035f, 0) },
            { Crater.SLOT_22_LBP1, new Vector4(0.35630608f, 0.3279511f, 0.8749252f, 0) },
            { Crater.SLOT_23_LBP1, new Vector4(0.512454f, 0.366131f, 0.776749f, 0) },
            { Crater.SLOT_24_LBP1, new Vector4(0.98978335f, -0.14198504f, 0.013014005f, 0) },
            { Crater.SLOT_25_LBP1, new Vector4(0.99952567f, -0.023080993f, 0.020388993f, 0) },
            { Crater.SLOT_26_LBP1, new Vector4(0.9697515f, -0.2230121f, 0.09923604f, 0) },
            { Crater.SLOT_27_LBP1, new Vector4(0.98948795f, 0.023391997f, 0.14271098f, 0) },
            { Crater.SLOT_28_LBP1, new Vector4(0.965258f, -0.047163f, 0.257007f, 0) },
            { Crater.SLOT_29_LBP1, new Vector4(0.6841198f, 0.72766775f, -0.049796984f, 0) },
            { Crater.SLOT_30_LBP1, new Vector4(-0.55120695f, -0.33277997f, -0.7651329f, 0) },
            { Crater.SLOT_31_LBP1, new Vector4(0.3719329f, 0.50006884f, 0.7820467f, 0) },
            { Crater.SLOT_32_LBP1, new Vector4(-0.38784105f, -0.21594504f, -0.8960731f, 0) },
            { Crater.SLOT_33_LBP1, new Vector4(-0.4184162f, -0.49700522f, -0.76020634f, 0) },
            { Crater.SLOT_34_LBP1, new Vector4(-0.261681f, -0.104449f, -0.959486f, 0) },
            { Crater.SLOT_35_LBP1, new Vector4(-0.26347908f, 0.8988393f, 0.3502381f, 0) },
            { Crater.SLOT_36_LBP1, new Vector4(-0.05115603f, 0.7022214f, -0.7101184f, 0) },
            { Crater.SLOT_37_LBP1, new Vector4(-0.021189002f, -0.70984006f, 0.70404404f, 0) },
            { Crater.SLOT_38_LBP1, new Vector4(-0.7321999f, 0.41059193f, 0.54341286f, 0) },
            { Crater.SLOT_39_LBP1, new Vector4(0.8426612f, -0.19560504f, -0.50165814f, 0) },
            { Crater.SLOT_40_LBP1, new Vector4(-0.24126509f, -0.2668241f, -0.93305737f, 0) },
            { Crater.SLOT_41_LBP1, new Vector4(0.7592101f, -0.010854001f, 0.65075505f, 0) },
            { Crater.SLOT_42_LBP1, new Vector4(-0.9484006f, -0.20853193f, -0.2388529f, 0) },
            { Crater.SLOT_43_LBP1, new Vector4(-0.9016544f, -0.39435717f, -0.17748709f, 0) },
            { Crater.SLOT_44_LBP1, new Vector4(-0.8763887f, -0.40167686f, -0.26570392f, 0) },
            { Crater.SLOT_45_LBP1, new Vector4(-0.93659484f, -0.32658395f, -0.12701596f, 0) },
            { Crater.SLOT_46_LBP1, new Vector4(-0.92078555f, -0.31372318f, -0.23180114f, 0) },
            { Crater.SLOT_47_LBP1, new Vector4(-0.8799429f, -0.34116998f, -0.33061096f, 0) },
            { Crater.SLOT_48_LBP1, new Vector4(-0.91347873f, -0.25022894f, -0.3208459f, 0) },
            { Crater.SLOT_49_LBP1, new Vector4(-0.95822436f, -0.24382709f, -0.14951406f, 0) },
            { Crater.SLOT_50_LBP1, new Vector4(0.4321622f, -0.37104517f, -0.8219254f, 0) },
            { Crater.SLOT_51_LBP1, new Vector4(-0.23641692f, 0.6839048f, -0.69020385f, 0) },
            { Crater.SLOT_52_LBP1, new Vector4(-0.6752077f, -0.6518117f, -0.34530583f, 0) },
            { Crater.SLOT_53_LBP1, new Vector4(-0.8629373f, 0.5012612f, -0.06384702f, 0) },
            { Crater.SLOT_54_LBP1, new Vector4(-0.41883606f, -0.85028714f, 0.31872904f, 0) },
            { Crater.SLOT_55_LBP1, new Vector4(-0.027164994f, 0.6557988f, 0.7544468f, 0) },
            { Crater.SLOT_56_LBP1, new Vector4(-0.5452938f, -0.13882895f, -0.82666874f, 0) },
            { Crater.SLOT_57_LBP1, new Vector4(0.61655706f, 0.18021101f, -0.76640815f, 0) },
            { Crater.SLOT_58_LBP1, new Vector4(0.17522402f, -0.8983221f, 0.40288207f, 0) },
            { Crater.SLOT_59_LBP1, new Vector4(-0.32325393f, -0.12421998f, 0.9381238f, 0) },
            { Crater.SLOT_60_LBP1, new Vector4(0.95858824f, -0.18041405f, 0.22036205f, 0) },
            { Crater.SLOT_61_LBP1, new Vector4(0.84370273f, 0.2576859f, -0.47091785f, 0) },
            { Crater.SLOT_62_LBP1, new Vector4(0.86589384f, 0.25325894f, 0.4313789f, 0) },
            { Crater.SLOT_63_LBP1, new Vector4(0.24578999f, 0.36295098f, -0.8988069f, 0) },
            { Crater.SLOT_64_LBP1, new Vector4(0.46892294f, -0.76497185f, -0.44150794f, 0) },
            { Crater.SLOT_65_LBP1, new Vector4(-0.3769459f, -0.3602679f, -0.85329884f, 0) },
            { Crater.SLOT_66_LBP1, new Vector4(0.11805903f, 0.3125141f, -0.9425482f, 0) },
            { Crater.SLOT_67_LBP1, new Vector4(0.24369888f, 0.2274599f, -0.9428005f, 0) },
            { Crater.SLOT_68_LBP1, new Vector4(-0.20356704f, -0.44608912f, -0.8715302f, 0) },
            { Crater.SLOT_69_LBP1, new Vector4(-0.82691664f, -0.26985687f, 0.4933418f, 0) },
            { Crater.SLOT_70_LBP1, new Vector4(-0.76749134f, -0.24230312f, 0.5935033f, 0) },
            { Crater.SLOT_71_LBP1, new Vector4(-0.80561f, -0.125551f, 0.57899f, 0) },
            { Crater.SLOT_72_LBP1, new Vector4(-0.8650643f, -0.15859807f, 0.47593117f, 0) },
            { Crater.SLOT_81_LBP1, new Vector4(0.5242757f, -0.5701827f, 0.6324766f, 0) }
        };

        public static Vector4 GetValue(this Crater crater)
        {
            return _values.TryGetValue(crater, out var value) ? value : Vector4.Zero;
        }
    }
}