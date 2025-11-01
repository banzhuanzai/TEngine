using UnityEngine;
using TEngine;

namespace GameLogic
{
	[Window(UILayer.UI,location:"TestUI")]
	class TestUI : UIWindow
	{
		#region 脚本工具生成的代码
		RectTransform _rectContainer;
		GameObject _itemTouch;
		GameObject _goTopInfo;
		GameObject _itemRoleInfo;
		GameObject _itemMonsterInfo;

		protected override void ScriptGenerator()
		{
			_rectContainer = FindChildComponent<RectTransform>("m_rectContainer");
			_itemTouch = FindChild("m_rectContainer/m_itemTouch").gameObject;
			_goTopInfo = FindChild("m_goTopInfo").gameObject;
			_itemRoleInfo = FindChild("m_goTopInfo/m_itemRoleInfo").gameObject;
			_itemMonsterInfo = FindChild("m_goTopInfo/m_itemMonsterInfo").gameObject;
		}
		#endregion

		#region 事件
		#endregion

		protected override void OnInit()
		{

		}

		protected override void OnShow()
		{

		}

		protected override void OnHide()
		{

		}
	}
}
