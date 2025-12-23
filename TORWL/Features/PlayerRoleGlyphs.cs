using System;
using MiraAPI.Events;
using MiraAPI.Events.Vanilla.Gameplay;
using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using Reactor.Utilities.Extensions;
using UnityEngine;

namespace TORWL.Features
{
	// Token: 0x0200002C RID: 44
	public class RoleIcons
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x000045E0 File Offset: 0x000027E0
		public static bool CanLocalPlayerSeeRole(RoleBehaviour role)
		{
			ICustomRole customRole = role as ICustomRole;
			if (customRole != null)
			{
				return customRole.CanLocalPlayerSeeRole(PlayerControl.LocalPlayer);
			}
			return (PlayerControl.LocalPlayer.Data.Role.IsImpostor && role.Player.Data.Role.IsImpostor) || PlayerControl.LocalPlayer.Data.IsDead;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004644 File Offset: 0x00002844
		[RegisterEvent(0)]
		private static void OnSetRole(SetRoleEvent e)
		{
			RoleIcons.TryClearRoleIcon(e.Player);
			RoleBehaviour role = e.Player.Data.Role;
			if (RoleIcons.CanLocalPlayerSeeRole(role))
			{
				GameObject gameObject = new GameObject("RoleIcon");
				gameObject.transform.SetParent(e.Player.cosmetics.nameTextContainer.transform);
				gameObject.transform.localPosition = new Vector3(0f, 0.4f, 0f);
				Sprite roleIcon = RoleIcons.GetRoleIcon(role);
				gameObject.transform.localScale = RoleIcons.GetRoleIconScale(roleIcon, role is ICustomRole);
				gameObject.AddComponent<SpriteRenderer>().sprite = roleIcon;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000046EC File Offset: 0x000028EC
		private static Vector3 GetRoleIconScale(Sprite icon, bool isCustomRole)
		{
			float num = isCustomRole ? 0.32f : 0.16f;
			return new Vector3((float)icon.texture.height / icon.pixelsPerUnit / num, (float)icon.texture.height / icon.pixelsPerUnit / num, 1f);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004740 File Offset: 0x00002940
		public static void TryClearRoleIcon(PlayerControl player)
		{
			Transform transform = player.cosmetics.nameTextContainer.transform.FindChild("RoleIcon");
			GameObject gameObject = (transform != null) ? transform.gameObject : null;
			if (gameObject)
			{
				gameObject.gameObject.Destroy();
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004788 File Offset: 0x00002988
		public static Sprite GetRoleIcon(RoleBehaviour role)
		{
			ICustomRole customRole = role as ICustomRole;
			if (customRole == null)
			{
				return role.RoleIconSolid;
			}
			LoadableAsset<Sprite> icon = customRole.Configuration.Icon;
			if (icon == null)
			{
				return null;
			}
			return icon.LoadAsset();
		}
	}
}
