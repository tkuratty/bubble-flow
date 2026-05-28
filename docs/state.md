# 現在の状態

最終更新: 2026-05-28

## 概要
- 640x480 ウィンドウに 10x10 の白い四角を中央表示し、WASD / 左スティックで秒速10pxで移動・画面端クランプする最小プレイアブル
- Godot 4.6.3 (.NET / C#) / Windows / headless 開発
- 視覚確認は GUI 起動が必要（headless では build/import/起動エラー無しのみ確認可）

## 直近の作業
- `project.godot` に viewport 640x480 と `move_left/right/up/down` の InputMap（WASD + Joypad 左スティック）を追加
- `scripts/Main.cs` を `Node2D` 化し、`_Process` で `Input.GetVector` → クランプ → `Position` 更新、`_Draw` で 10x10 矩形を描画
- `scenes/Main.tscn` のルート型を `Node` → `Node2D` に変更
- `dotnet build` / `godot --headless --import` / `godot --headless --quit-after 30` がエラー無し

## 次にやること
- [ ] GUI 起動による視覚確認（ユーザ側）
- [ ] テストプロジェクト (`tests/`) 追加と `dotnet test` 動作確認

## 既知の問題
- なし
