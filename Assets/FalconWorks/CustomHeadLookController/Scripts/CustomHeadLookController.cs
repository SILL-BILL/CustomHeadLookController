using UnityEngine;
using System.Collections;

public class CustomHeadLookController : HeadLookController {

	// --------
	#region インスペクタ設定用フィールド
	[Header("*Custom Settings")]
	/// <summary>
	/// the look target transform.
	/// </summary>
	[SerializeField] private Transform m_LookTargetTransform;
	/// <summary>
	/// [プロパティ] the look target transform.
	/// </summary>
	public Transform LookTargetTransform {
		get { return m_LookTargetTransform; }
		set { m_LookTargetTransform = value; }
	}
	/// <summary>
	/// the neutral look transform.
	/// </summary>
	[SerializeField] private Transform m_NeutralLookTransform;
	/// <summary>
	/// [プロパティ]the neutral look transform.
	/// </summary>
	public Transform NeutralLookTransform {
		get { return m_NeutralLookTransform; }
		set { m_NeutralLookTransform = value; }
	}
	/// <summary>
	/// 対象のオブジェクトに対して注視するか否かのフラグ
	/// </summary>
	[SerializeField] private bool m_TargetLookActive;
	/// <summary>
	/// [プロパティ]対象のオブジェクトに対して注視するか否かのフラグ
	/// </summary>
	public bool TargetLookActive {
		get{ return m_TargetLookActive; }
		set { m_TargetLookActive = value; }
	}
	#endregion //インスペクタ設定用フィールド

	// --------
	#region メンバフィールド
	#endregion //メンバフィールド

	// --------
	#region MonoBehaviourメソッド
	/// <summary>
	/// 開始処理
	/// </summary>
	protected override void Start() {
		base.Start();
	}

	/// <summary>
	/// 更新処理
	/// </summary>
	protected override void LateUpdate() {

		base.target = getLookTargetPosition();

		base.LateUpdate();
	}
	#endregion //MonoBehaviourメソッド

	// --------
	#region メンバメソッド
	private Vector3 getLookTargetPosition(){
		Vector3 pos = Vector3.zero;

		if(TargetLookActive){
			pos = LookTargetTransform.position;
		}else{
			pos = NeutralLookTransform.position;
		}

		return pos;
	}

	public override void DisableHeadLookFadeOut(){
		base.DisableHeadLookFadeOut();
	}

	public override void EnableHeadLookFadeIn(){
		base.EnableHeadLookFadeIn();
	}
	#endregion //メンバメソッド
}