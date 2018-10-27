namespace EducationalPlans.Domain
{
    public class ПараметрыПлана : BaseModel {
        public int rowOrder { get; set; }
        public string hasChanges { get; set; }
        public int КодПлана { get; set; }
        public int count { get; set; }
        public bool Flag_FillTitle { get; set; }
        public bool Flag_SrokO { get; set; }
        public int SrokOYear { get; set; }
        public int SrokOMonth { get; set; }
        public bool Flag_OOPItog { get; set; }
        public int OOPItog { get; set; }
        public bool Flag_OOPyear { get; set; }
        public int OOPyear { get; set; }
        public bool Flag_ZETdelta { get; set; }
        public bool Flag_DVVpersent { get; set; }
        public bool Flag_DVVpersent1p3 { get; set; }
        public int DVVpersent30Min { get; set; }
        public int DVVpersent30Max { get; set; }
        public bool Flag_BasePart { get; set; }
        public int BasePartMin { get; set; }
        public int BasePartMax { get; set; }
        public bool Flag_ZETDiscMin { get; set; }
        public int ZETDiscMin { get; set; }
        public bool Flag_DiscZETIsInt { get; set; }
        public bool Flag_DiscZETYearIsInt { get; set; }
        public bool Flag_ZETExpertTrue { get; set; }
        public bool Flag_DiscZETExpertTrue { get; set; }
        public bool Flag_HinW54 { get; set; }
        public int HinW54 { get; set; }
        public bool Flag_HinWAudit { get; set; }
        public int HinWAuditMin { get; set; }
        public int HinWAuditMax { get; set; }
        public bool Flag_HinWAuditSr { get; set; }
        public int HinWAuditSrMin { get; set; }
        public int HinWAuditSrMax { get; set; }
        public bool Flag_Lect { get; set; }
        public int LectMin { get; set; }
        public int LectMax { get; set; }
        public bool Flag_Inter { get; set; }
        public int InterMin { get; set; }
        public int InterMax { get; set; }
        public bool Flag_ZETAndHoursIsTrue { get; set; }
        public bool Flag_DiscZETAndHoursIsTrue { get; set; }
        public bool Flag_DiscSemZETAndHoursIsTrue { get; set; }
        public bool Flag_AuditAll { get; set; }
        public int AuditAllMin { get; set; }
        public int AudetAllMax { get; set; }
        public bool Flag_EqZET36 { get; set; }
        public int EqZET36 { get; set; }
        public bool Flag_EqZETDis32_38 { get; set; }
        public bool Flag_CntrlEx { get; set; }
        public int CntrlExMin { get; set; }
        public int CntrlExMax { get; set; }
        public bool Flag_CntrlExSem { get; set; }
        public int CntrlExSemMax { get; set; }
        public bool Flag_CntrlZach { get; set; }
        public int CntrlZachMin { get; set; }
        public int CntrlZachMax { get; set; }
        public bool Flag_CntrlZachSem { get; set; }
        public int CntrlZachSemMax { get; set; }
        public bool Flag_CntrlKP { get; set; }
        public int CntrlKPMax { get; set; }
        public bool Flag_CntrlKR { get; set; }
        public int CntrlKRMax { get; set; }
        public bool Flag_CntrlExHours { get; set; }
        public int CntrlExHoursMin { get; set; }
        public int CntrlExHoursMax { get; set; }
        public bool Flag_CntrlHasHours { get; set; }
        public bool Flag_CntrlHasHoursItogS { get; set; }
        public bool Flag_HoursCouple { get; set; }
        public bool Flag_HoursKratNed { get; set; }
        public bool Flag_HoursKratNedFirstPos { get; set; }
        public bool Flag_HoursKSRForKR { get; set; }
        public int HoursKSRForKRMin { get; set; }
        public int HoursKSRForKRMax { get; set; }
        public bool Flag_HoursKSRForKP { get; set; }
        public int HoursKSRForKPMin { get; set; }
        public int HoursKSRForKPMax { get; set; }
        public bool Flag_HoursKSRpSRS { get; set; }
        public int HoursKSRpSRSMin { get; set; }
        public int HoursKSRpSRSMax { get; set; }
        public bool Flag_HoursAudSemTrue { get; set; }
        public bool Flag_HoursAudSemTrueWithKSR { get; set; }
        public bool Flag_HoursSRSSemTrue { get; set; }
        public bool Flag_HoursSRSSemTrueWithKSR { get; set; }
        public bool Flag_PracticsWeeksCorrrect { get; set; }
        public bool Flag_HolidaysWeeks { get; set; }
        public int HolidaysWeeksMin { get; set; }
        public int HolidaysWeeksMax { get; set; }
        public bool Flag_HolidaysWinterWeeks { get; set; }
        public int HolidaysWinterWeeksMin { get; set; }
        public int HolidaysWinterWeeksMax { get; set; }
        public bool Flag_DiscAltTrue { get; set; }
        public bool Flag_DiscDiscMust { get; set; }
        public bool Flag_DiscCompTrue { get; set; }
        public bool Flag_DiscCompDBTrue { get; set; }
        public bool Flag_DiscCompHandMadeTrue { get; set; }
        public int DiscCompHandMadeOK { get; set; }
        public int DiscCompHandMadePK { get; set; }
        public bool Flag_BaseDiscCompTrue { get; set; }
        public bool Flag_DiscMinOneCompTrue { get; set; }
        public bool Flag_DiscFatalCoincidence { get; set; }
        public bool Flag_DiscKafTrue { get; set; }
        public bool Flag_DiscPhysCZET { get; set; }
        public int DiscPhysCZET { get; set; }
        public bool Flag_DiscPhysCHours { get; set; }
        public int DiscPhysCHours { get; set; }
        public bool Flag_DiscPhysCHoursPractices { get; set; }
        public int DiscPhysCHoursPractices { get; set; }
        public bool Flag_DiscJustificationZETLocationForCourses { get; set; }
        public int DiscJustificationZETLocationForCoursesPosition { get; set; }
        public int DiscJustificationZETLocationForCoursesOneZET { get; set; }
        public bool Flag_ZET_Pereat { get; set; }
        public int ZET_Pereat { get; set; }
        public int HinWEx54 { get; set; }
        public bool ShowIndex { get; set; }
        public bool ShowCmpt { get; set; }
        public bool ShowKafCode { get; set; }
        public bool ShowZETExp { get; set; }
        public bool ShowZETFact { get; set; }
        public bool ShowHinZET { get; set; }
        public bool ShowHFromZET { get; set; }
        public bool ShowHFromPlan { get; set; }
        public bool ShowItogoKontact { get; set; }
        public bool ShowItogoAud { get; set; }
        public bool ShowItogoSRS { get; set; }
        public bool ShowItogoCtrl { get; set; }
        public bool ShowItogoInter { get; set; }
        public bool ShowItogoDist { get; set; }
        public bool ShowKafName { get; set; }
        public bool ShowZETPereatt { get; set; }
        public bool ShowZETOstIzuch { get; set; }
        public bool ShowHoursPereatt { get; set; }
        public bool ShowHoursOstIzuch { get; set; }
        public bool ShowZETIm { get; set; }
        public bool ShowHItogIm { get; set; }
        public bool ShowHKontactIm { get; set; }
        public bool ShowHAudIm { get; set; }
        public bool ShowHInterIm { get; set; }
        public bool ShowHDistIm { get; set; }
        public bool ViewHinWeek { get; set; }
        public bool FlagSaveParamView { get; set; }
        public bool IsEqualsDV { get; set; }
        public bool IsNotEqualsVZ { get; set; }
        public bool IsNotEqualsCtrl { get; set; }
        public bool IsNotEqualsOther { get; set; }
        public bool IsSetEquals { get; set; }
        public int NormHoursEx { get; set; }
        public int NormHoursZ { get; set; }
        public int NormHoursZo { get; set; }
        public bool ZETDiscMinNotDB { get; set; }
        public bool ZETDiscMinNotRazdel { get; set; }
        public bool FlagKRAll { get; set; }
        public bool FlagKPAll { get; set; }
        public int KRAllCount { get; set; }
        public int KPAllCount { get; set; }
        public bool FlagKRYear { get; set; }
        public bool FlagKPYear { get; set; }
        public bool FlagKRSem { get; set; }
        public bool FlagKPSem { get; set; }
        public int KRSemCount { get; set; }
        public int KPSemCount { get; set; }
        public bool KontSemSelect { get; set; }
        public bool IsEqualsCmpt { get; set; }
        public bool IsNotEqualsOK { get; set; }
        public bool IsNotEqualsOPK { get; set; }
        public bool IsNotEqualsPK { get; set; }
        public bool FlagAssistKanik { get; set; }
        public bool Flag_CntrlHasHoursItogWithMod { get; set; }
        public bool FlagVisibleAudN { get; set; }
        public bool IsNotIncludePhizk { get; set; }
        public bool IsNotIncludeFacult { get; set; }
        public bool IsEqualsPersons { get; set; }
        public bool DifPrInTabPract { get; set; }
        public bool DifPrInSes { get; set; }
        public bool OnlyGinGYP { get; set; }
        public bool YPrWithTO { get; set; }
        public bool IsWithoutZE { get; set; }
        public int UpdIndex { get; set; }
        public bool GIAforProfil { get; set; }
        public bool CmptWithoutGIA { get; set; }
        public bool ElectDiscInBasePart { get; set; }
        public bool IsEqualsProfSt { get; set; }
        public int SesViewOption { get; set; }
        public bool FlagLecOP { get; set; }
        public int MaxLecOP { get; set; }
        public bool FlagSemOP { get; set; }
        public int MaxSemOP { get; set; }
        public bool NoCmptInHeadDVB { get; set; }
        public int TypeHours { get; set; }
        public bool FlagIsFacult { get; set; }
        public bool FlagCmptPractics { get; set; }
        public bool FlagMinBase { get; set; }
        public int MinPercBase { get; set; }
        public bool Flag_OOPYearNew { get; set; }
        public int OOPYearNew { get; set; }
    }
}