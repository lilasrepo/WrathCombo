# Wrath Combo（繁中移植版 · TC13） / Traditional-Chinese Port

> 把連段與互斥技能整合到單一按鍵上——還不只如此。<br>
> Condenses combos and mutually exclusive abilities onto a single button — and then some.

**繁體中文**：這是 **[Wrath Combo](https://github.com/PunishXIV/WrathCombo)** 的繁體中文客戶端移植版，對應 **FFXIV 7.20 / yanmucorp Dalamud API13（.NET 9）**。本專案僅做相容性移植，**非官方、非原作維護**；所有原始功能與設計著作權歸原作者 **Team Wrath**。

**English**: A Traditional-Chinese-client port of **[Wrath Combo](https://github.com/PunishXIV/WrathCombo)** targeting **FFXIV 7.20 / yanmucorp Dalamud API13 (.NET 9)**. Compatibility port only — **unofficial and not maintained by the original author**. All original work © **Team Wrath**.

---

## 這是什麼 / About

把整套連段與彼此互斥的技能濃縮成一顆按鍵，並提供 PvE／PvP 的自動循環（autorotation）功能。

Collapses combos and mutually exclusive abilities onto one button, with PvE/PvP auto-rotation support.

## 安裝 / Installation

**繁體中文**
1. 使用 **XIVTCLauncher** 啟動繁體中文客戶端。
2. 遊戲內輸入 `/xlsettings` → 切到 **Experimental** 分頁 → **Custom Plugin Repositories（自訂插件庫）**。
3. 貼上下列網址並按 **+** 儲存：
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. 輸入 `/xlplugins`，搜尋 **Wrath Combo (TC13)** → 安裝 → 啟用。

**English**
1. Launch the Traditional-Chinese client with **XIVTCLauncher**.
2. In-game, type `/xlsettings` → **Experimental** tab → **Custom Plugin Repositories**.
3. Add this URL and save with **+**:
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. Type `/xlplugins`, search **Wrath Combo (TC13)** → Install → Enable.

## 對應版本 / Compatibility

| 項目 / Item | 版本 / Version |
|---|---|
| 遊戲 / Game | FFXIV 7.20（繁中客戶端 / TC client） |
| Dalamud | yanmucorp API13（.NET 9） |
| 移植自上游 / Ported from upstream | v1.0.4.8 |

## 原作與授權 / Credits & License

本專案 fork 自 **[PunishXIV/WrathCombo](https://github.com/PunishXIV/WrathCombo)**，授權沿用上游；所有原始功能著作權歸 **Team Wrath**。<br>
Forked from **[PunishXIV/WrathCombo](https://github.com/PunishXIV/WrathCombo)**. License follows upstream; all original work © **Team Wrath**.

## 免責聲明 / Disclaimer

Below you can find a small example of some of the features and options we offer in
Wrath Combo. <br>
Please note, this is just an excerpt and is not representative of the full
feature-set.


  <details><summary>PvE Features</summary> <br>

 - "Simple" (one-button) Mode for many jobs
 - "Advanced" Mode for many jobs, get as simple as you want
 - Auto-Rotation, to execute your rotation automatically, based on your settings
 - Variant Dungeon specific features
<br><br>
 - Tank Double Reprisal Protection
 - Tank Interrupt Feature
 - Healer Raise Feature
 - Magical Ranged DPS Double Addle Protection
 - Magical Ranged DPS Raise Feature
 - Melee DPS Double Feint Protection
 - Melee DPS True North Protection
 - Physical Ranged DPS Double Mitigation Protection
 - Physical Ranged DPS Interrupt Feature
    
 And much more!

  </details>

  <details><summary>PvP Features</summary> <br>

 - "Burst Mode" offense features for all jobs
 - Emergency Heals
 - Emergency Guard
 - Quick Purify
 - Guard Cancellation Prevention
    
 And much more!

  </details>

  <details><summary>Miscellaneous Features</summary> <br>

- Island Sanctuary Sprint Feature
- [BTN/MIN] Eureka Feature
- [BTN/MIN] Locate & Truth Feature
- [FSH] Cast to Hook Feature
- [FSH] Diving Feature

 And much more!

  </details>

To experience the full set of features on
offer, <a href="#installation" alt="install">install</a> the plugin or visit
the [Discord](https://discord.gg/Zzrcc8kmvy) server for more info.

<p align="right"><a href="#top" alt="Back to top"><img src=/res/readme_images/arrowhead-up.png width ="25"/></a></p>

## Use with Other Plugins

### [Orbwalker](https://puni.sh/plugin/Orbwalker)

Wrath Combo can use Orbwalker to stop player movement in Auto-Rotation mode 
instead of requiring the player to stop before choosing to cast.

1. Open Wrath Combo's Auto-Rotation Settings: `/wrath autosettings`.
2. Check "Enable Orbwalker Integration".
3. Open Orbwalker and confirm your settings: `/orbwalker`.

### [AutoDuty](https://github.com/erdelf/AutoDuty)

Wrath Combo can be used as the Rotation Engine for AutoDuty, such that Wrath Combo's
Auto-Rotation will be used during duties.
To enable this:
1. Open AutoDuty's Config window: `/autoduty cfg`.
2. Expand the "Duty Config Settings" section.
3. Enable "Auto Manage Rotation Plugin State".
4. (Also check "> Wrath Config Options <" -> "Auto setup jobs for autorotation")\
   (if you already have your jobs setup, you can skip this step)

### [Questionable](https://puni.sh/plugin/questionable)

Wrath Combo can be used as the Combat Module for Questionable, such that Wrath 
Combo's Auto-Rotation will be employed during questing.
To enable this:
1. Open Questionable's Settings window: `/qst config`.
2. Go to the "General" tab.
3. Select "Wrath Combo" as the "Preferred Combat Module".

> By default, the two plugins above will ensure that combos in Wrath are set up, and
will lock all settings under those combos to `On` if combos were not set up, to
ensure that the rotation will run.

  <p align="right"><a href="#top" alt="Back to top"><img src=/res/readme_images/arrowhead-up.png width ="25"/></a></p>
</section> 

<!-- Commands -->
<section>

# Commands

| **Chat command**                       | **Function**                                                                                                                                                                   |
|:---------------------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `/wrath`                               | Toggles the main plugin window, where you can enable/disable features, access settings and more.                                                                               |
| `/wrath pve`                           | Opens the main plugin window, to the PvE tab.                                                                                                                                  |
| `/wrath pvp`                           | Opens the main plugin window, to the PvP tab.                                                                                                                                  |
| `/wrath settings`                      | Opens the main plugin window, to the Settings tab.                                                                                                                             |
| `/wrath autosettings`                  | Opens the main plugin window, to the Auto-Rotation tab.                                                                                                                        |
| `/wrath customactions`                 | Opens the main plugin window, to the Custom Actions tab.                                                                                                                       |
| `/wrath <X>`                           | Opens the main plugin window, to a specific job's PvE features.<br>Replace `<X>` with the jobs abbreviation.                                                                   |
| `/wrath burst`                         | Toggles all Burst-related Features in your Advanced Mode (and only Advanced Mode) Combo.<br>(is functionally the same as using a [Burst Holding Macro](https://github.com/zbee/WrathCombo/blob/core/commands/docs/BurstHoldingMacros.md)) |
| `/wrath burst <X>`                     | Sets Burst-related Features in your Advanced Mode Combo to a specific state.<br>Replace `<X>` with `enable` or `disable`. |
| `/wrath auto`                          | Toggles Auto-Rotation **on** or **off**.                                                                                                                                       |
| `/wrath auto <X>`                      | Sets Auto-Rotation to a specific state.<br>Replace `<X>` with `on`, `off`, or `toggle`.                                                                                        |
| `/wrath auto target <X> <Y>`           | Sets Auto-Rotation targeting mode.<br>Replace `<X>` with `damage` or `healer`.<br>For damage, `<Y>` can be: `manual`, `highest_max`, `lowest_max`, `highest_current`, `lowest_current`, `tank_target`, `nearest`, `furthest`.<br>For healer, `<Y>` can be: `manual`, `highest_current`, `lowest_current`. |
| `/wrath combo`                         | Toggles action replacing **on** or **off**.<br>When off, actions will not be replaced with combos from the plugin. Auto-Rotation will still work.                              |
| `/wrath combo <X>`                     | Sets action replacing to a specific state.<br>Replace `<X>` with `on`, `off`, or `toggle`.                                                                                     |
| `/wrath ignore`                        | Adds a targeted NPC, and all instances of it, to an ignore list for Auto-Rotation's auto-targeting.<br>Manage this list in the Auto-Rotation tab.                              |
| `/wrath toggle <X>`                    | Toggles a specific feature or option **on** or **off**. Does not work while in combat.<br>Replace `<X>` with its internal name (or ID).                                        |
| `/wrath set <X>`                       | Turns a specific feature/option **on**. Does not work when in combat.<br>Replace `<X>` with its internal name (or ID).                                                         |
| `/wrath unset <X>`                     | Turn a specific feature/option **off**. Does not work when in combat.<br>Replace `<X>` with its internal name (or ID).                                                         |
| `/wrath unsetall`                      | Turns all features and options **off** at once.                                                                                                                                |
| `/wrath list ...`                      | Prints lists of feature's internal names to the game chat based on filter arguments.<br>Requires an appended filter. See Below.                                                |
| `/wrath list set`<br/>`/wrath enabled` | Prints a list of all currently enabled features & options in the game chat.                                                                                                    |
| `/wrath list unset`                    | Prints a list of all currently disabled features & options in the game chat.                                                                                                   |
| `/wrath list all`                      | Prints a list of every feature & option in the game chat, regardless of state.                                                                                                 |
| `/wrath list ... <X>`                  | All list commands can also optionally accept a job parameter, to filter the list down to a specific job.<br>Replace `<X>` with the jobs abbreviation.                          |
| `/wrath opener`                        | Outputs your current openers status to chat.                                                                                                                                   |
| `/wrath debug`                         | Outputs a debug file to your desktop containing only relevant features/options for your current job.<br>To be sent to developers, to help in bug-fixing. Completely anonymous. |
| `/wrath debug <X>`                     | Outputs a debug file containing only job-relevant features/options.<br>Replace `<X>` with the jobs abbreviation.                                                               |
| `/wrath debug all`                     | Outputs a debug file containing all features/options.                                                                                                                          |

<p align="right"><a href="#top" alt="Back to top"><img src=/res/readme_images/arrowhead-up.png width ="25"/></a></p>
</section>

<!-- Contributing -->
<section>

# Contributing

Contributions to the project are always welcome - please feel free to submit
a [pull request](https://github.com/PunishXIV/WrathCombo/pulls) here on GitHub,
but ideally get in contact with us over on
the [Discord](https://discord.gg/Zzrcc8kmvy) server so we can communicate with one
another to make any necessary changes and review your submission!

You may also find [contributing info](CONTRIBUTING.md) and
[available guides](CONTRIBUTING.md#guides-on-using-specific-parts-of-wrath) helpful
in getting started.

   <p align="right"><a href="#top" alt="Back to top"><img src=/res/readme_images/arrowhead-up.png width ="25"/></a></p>
</section>

<br><br>

<!-- Attribution -->
<div align="center">
  <a href="https://puni.sh/" alt="Puni.sh">
    <img src="https://github.com/PunishXIV/AutoHook/assets/13919114/a8a977d6-457b-4e43-8256-ca298abd9009" /></a>
<br>
  <a href="https://discord.gg/Zzrcc8kmvy" alt="Discord">
    <img src="https://discordapp.com/api/guilds/1001823907193552978/embed.png?style=banner2" /></a>
</div>
