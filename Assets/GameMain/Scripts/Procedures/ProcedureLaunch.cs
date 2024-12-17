using System.Collections;
using System.Collections.Generic;
using GameFramework.Localization;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace TowerMon
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnInit(ProcedureOwner procedureOwner)
        {
            base.OnInit(procedureOwner);
        }
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            /*
            // ������Ϣ�������汾ʱ����һЩ������ Json �ĸ�ʽд�� Assets/GameMain/Configs/BuildInfo.txt������Ϸ�߼���ȡ
            GameEntry.BuiltinData.InitBuildInfo();

            // �������ã����õ�ǰʹ�õ����ԣ���������ã���Ĭ��ʹ�ò���ϵͳ���ԡ�
            InitLanguageSettings();

            // �������ã�����ʹ�õ����ԣ�֪ͨ�ײ���ض�Ӧ����Դ����
            InitCurrentVariant();

            // Ĭ���ֵ䣺����Ĭ���ֵ��ļ� Assets/GameMain/Configs/Default
            // ���ֵ��ļ���¼����Դ����ǰʹ�õĸ������Ե��ַ��������� App һ�𷢲����ʲ��ɸ���
            GameEntry.BuiltinData.InitDefaultDictionary();
            */
            base.OnEnter(procedureOwner);
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            ChangeState<ProcedureSplash>(procedureOwner);
        }


        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
        }

        protected override void OnDestroy(ProcedureOwner procedureOwner)
        {
            base.OnDestroy(procedureOwner);
        }


    }
}