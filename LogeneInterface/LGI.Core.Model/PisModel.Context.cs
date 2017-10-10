﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LGI.Core.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PathnetEntities : DbContext
    {
        public PathnetEntities()
            : base("name=PathnetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<MDM_CYC> MDM_CYC { get; set; }
        public virtual DbSet<T_BB> T_BB { get; set; }
        public virtual DbSet<T_BBLC_CYC> T_BBLC_CYC { get; set; }
        public virtual DbSet<T_BCBG> T_BCBG { get; set; }
        public virtual DbSet<T_BDBG> T_BDBG { get; set; }
        public virtual DbSet<T_BG_PDF> T_BG_PDF { get; set; }
        public virtual DbSet<T_BG_ZLPJ> T_BG_ZLPJ { get; set; }
        public virtual DbSet<T_BGFF> T_BGFF { get; set; }
        public virtual DbSet<T_BGHJ> T_BGHJ { get; set; }
        public virtual DbSet<T_BJW_CS> T_BJW_CS { get; set; }
        public virtual DbSet<T_BJW_CYC> T_BJW_CYC { get; set; }
        public virtual DbSet<T_BJWTC> T_BJWTC { get; set; }
        public virtual DbSet<T_BLK_CS> T_BLK_CS { get; set; }
        public virtual DbSet<T_CG_CYC> T_CG_CYC { get; set; }
        public virtual DbSet<T_CGBW_TREE> T_CGBW_TREE { get; set; }
        public virtual DbSet<T_CYC> T_CYC { get; set; }
        public virtual DbSet<T_CYC_FL> T_CYC_FL { get; set; }
        public virtual DbSet<T_DK_CS> T_DK_CS { get; set; }
        public virtual DbSet<T_FSDX> T_FSDX { get; set; }
        public virtual DbSet<T_ICD10_BM> T_ICD10_BM { get; set; }
        public virtual DbSet<T_JCXX> T_JCXX { get; set; }
        public virtual DbSet<T_jcxx_fs> T_jcxx_fs { get; set; }
        public virtual DbSet<T_JHP> T_JHP { get; set; }
        public virtual DbSet<T_JSYZ> T_JSYZ { get; set; }
        public virtual DbSet<T_KNHZ> T_KNHZ { get; set; }
        public virtual DbSet<T_LB_CS> T_LB_CS { get; set; }
        public virtual DbSet<T_LK> T_LK { get; set; }
        public virtual DbSet<T_LKTMSY> T_LKTMSY { get; set; }
        public virtual DbSet<T_LOG_YH> T_LOG_YH { get; set; }
        public virtual DbSet<T_mq_log> T_mq_log { get; set; }
        public virtual DbSet<T_PATHCOM_TJYZ> T_PATHCOM_TJYZ { get; set; }
        public virtual DbSet<T_QC_RYSJ> T_QC_RYSJ { get; set; }
        public virtual DbSet<T_QCMX> T_QCMX { get; set; }
        public virtual DbSet<T_QCMX_TEMP> T_QCMX_TEMP { get; set; }
        public virtual DbSet<T_QP> T_QP { get; set; }
        public virtual DbSet<T_QP_JGPJ> T_QP_JGPJ { get; set; }
        public virtual DbSet<T_QP_YDY> T_QP_YDY { get; set; }
        public virtual DbSet<T_SF> T_SF { get; set; }
        public virtual DbSet<T_SF_JEZK> T_SF_JEZK { get; set; }
        public virtual DbSet<T_SF_XM> T_SF_XM { get; set; }
        public virtual DbSet<T_SF_XMZK> T_SF_XMZK { get; set; }
        public virtual DbSet<T_SQD> T_SQD { get; set; }
        public virtual DbSet<T_SQD_BBXX> T_SQD_BBXX { get; set; }
        public virtual DbSet<T_TBS_BG> T_TBS_BG { get; set; }
        public virtual DbSet<T_TBS_SY> T_TBS_SY { get; set; }
        public virtual DbSet<T_TBS_XSGS_COMBO> T_TBS_XSGS_COMBO { get; set; }
        public virtual DbSet<T_TBS_XSGS_LABEL> T_TBS_XSGS_LABEL { get; set; }
        public virtual DbSet<T_TBS_XSGS_LINE> T_TBS_XSGS_LINE { get; set; }
        public virtual DbSet<T_TBS_XSGS_TEXT> T_TBS_XSGS_TEXT { get; set; }
        public virtual DbSet<T_TJYZ> T_TJYZ { get; set; }
        public virtual DbSet<T_TJYZ_YKD> T_TJYZ_YKD { get; set; }
        public virtual DbSet<T_TX> T_TX { get; set; }
        public virtual DbSet<T_XBX_TREE> T_XBX_TREE { get; set; }
        public virtual DbSet<T_XGYJ> T_XGYJ { get; set; }
        public virtual DbSet<T_YH> T_YH { get; set; }
        public virtual DbSet<T_YHZ> T_YHZ { get; set; }
        public virtual DbSet<T_BGGD> T_BGGD { get; set; }
        public virtual DbSet<T_SC> T_SC { get; set; }
        public virtual DbSet<T_SJ_CKB> T_SJ_CKB { get; set; }
        public virtual DbSet<T_SJ_CYC> T_SJ_CYC { get; set; }
        public virtual DbSet<T_SJ_CYCFL> T_SJ_CYCFL { get; set; }
        public virtual DbSet<T_SJ_GYS> T_SJ_GYS { get; set; }
        public virtual DbSet<T_SJ_KCB> T_SJ_KCB { get; set; }
        public virtual DbSet<T_SJ_SCCJ> T_SJ_SCCJ { get; set; }
        public virtual DbSet<T_SJ_WL> T_SJ_WL { get; set; }
        public virtual DbSet<T_SJ_WLZ> T_SJ_WLZ { get; set; }
        public virtual DbSet<T_SZ> T_SZ { get; set; }
        public virtual DbSet<T_SZQM> T_SZQM { get; set; }
        public virtual DbSet<examrecord> examrecords { get; set; }
        public virtual DbSet<TB> TBS { get; set; }
        public virtual DbSet<V_BCBG_SH> V_BCBG_SH { get; set; }
        public virtual DbSet<V_BDBG> V_BDBG { get; set; }
        public virtual DbSet<V_BDBG_bfk> V_BDBG_bfk { get; set; }
        public virtual DbSet<V_BDBG_hb> V_BDBG_hb { get; set; }
        public virtual DbSet<V_BDBG_HFZ_BDVIEW> V_BDBG_HFZ_BDVIEW { get; set; }
        public virtual DbSet<V_BGYS> V_BGYS { get; set; }
        public virtual DbSet<v_blk> v_blk { get; set; }
        public virtual DbSet<V_BM_DBM> V_BM_DBM { get; set; }
        public virtual DbSet<V_brxx> V_brxx { get; set; }
        public virtual DbSet<V_CX> V_CX { get; set; }
        public virtual DbSet<V_DJB> V_DJB { get; set; }
        public virtual DbSet<V_DYTX> V_DYTX { get; set; }
        public virtual DbSet<V_DZP> V_DZP { get; set; }
        public virtual DbSet<V_HIS_BLBG> V_HIS_BLBG { get; set; }
        public virtual DbSet<V_HIS_TX> V_HIS_TX { get; set; }
        public virtual DbSet<V_JSTJYZ> V_JSTJYZ { get; set; }
        public virtual DbSet<V_JSTJYZ2> V_JSTJYZ2 { get; set; }
        public virtual DbSet<V_LK> V_LK { get; set; }
        public virtual DbSet<V_PATHCOM_TJYZ> V_PATHCOM_TJYZ { get; set; }
        public virtual DbSet<V_PDF_TO_APP> V_PDF_TO_APP { get; set; }
        public virtual DbSet<V_QP> V_QP { get; set; }
        public virtual DbSet<V_QP_BQDY> V_QP_BQDY { get; set; }
        public virtual DbSet<V_QP_BQDY_050525> V_QP_BQDY_050525 { get; set; }
        public virtual DbSet<V_QP_BQDY_060125> V_QP_BQDY_060125 { get; set; }
        public virtual DbSet<V_QP_TJYZ_ID> V_QP_TJYZ_ID { get; set; }
        public virtual DbSet<V_QP_YDY> V_QP_YDY { get; set; }
        public virtual DbSet<V_QP_YDY_BQDY> V_QP_YDY_BQDY { get; set; }
        public virtual DbSet<V_QPGZB_JCXX> V_QPGZB_JCXX { get; set; }
        public virtual DbSet<V_QPGZB_QCMX> V_QPGZB_QCMX { get; set; }
        public virtual DbSet<V_QSB_BGYS> V_QSB_BGYS { get; set; }
        public virtual DbSet<V_QSB_BQ> V_QSB_BQ { get; set; }
        public virtual DbSet<V_QSB_SJKS> V_QSB_SJKS { get; set; }
        public virtual DbSet<v_sjks> v_sjks { get; set; }
        public virtual DbSet<v_SJYS> v_SJYS { get; set; }
        public virtual DbSet<V_TBS> V_TBS { get; set; }
        public virtual DbSet<v_tbs_value> v_tbs_value { get; set; }
        public virtual DbSet<V_TBS_XYLTJ> V_TBS_XYLTJ { get; set; }
        public virtual DbSet<v_tbs_yxl> v_tbs_yxl { get; set; }
        public virtual DbSet<v_tbsybb> v_tbsybb { get; set; }
        public virtual DbSet<V_TJ_BD> V_TJ_BD { get; set; }
        public virtual DbSet<V_TJ_BGFF> V_TJ_BGFF { get; set; }
        public virtual DbSet<V_TJ_BM> V_TJ_BM { get; set; }
        public virtual DbSet<V_TJ_FP_XGYJ> V_TJ_FP_XGYJ { get; set; }
        public virtual DbSet<V_TJ_JCXX> V_TJ_JCXX { get; set; }
        public virtual DbSet<V_TJ_JSYZ> V_TJ_JSYZ { get; set; }
        public virtual DbSet<V_TJ_JSYZ_BD> V_TJ_JSYZ_BD { get; set; }
        public virtual DbSet<V_TJ_JSYZ_BD1> V_TJ_JSYZ_BD1 { get; set; }
        public virtual DbSet<V_TJ_QCMX> V_TJ_QCMX { get; set; }
        public virtual DbSet<V_TJ_QP> V_TJ_QP { get; set; }
        public virtual DbSet<V_TJ_TBS> V_TJ_TBS { get; set; }
        public virtual DbSet<V_TJ_TJYZ> V_TJ_TJYZ { get; set; }
        public virtual DbSet<V_TJ_TR> V_TJ_TR { get; set; }
        public virtual DbSet<V_TJ_YSGZL_TJYZ> V_TJ_YSGZL_TJYZ { get; set; }
        public virtual DbSet<V_TJYZ> V_TJYZ { get; set; }
        public virtual DbSet<V_TJYZ_BJW> V_TJYZ_BJW { get; set; }
    }
}