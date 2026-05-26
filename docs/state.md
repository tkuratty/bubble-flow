# 現在の状態

最終更新: 2026-05-26

## 概要
- 最小プロジェクト雛形が稼働中
- Godot 4.6.3 (.NET / C#) / Windows / headless 開発
- `Main.tscn` → `Main.cs` の "Hello from BubbleFlow" 出力を headless 実行で確認済み

## 直近の作業
- `project.godot` / `BubbleFlow.csproj` / `BubbleFlow.sln` を生成
- `scenes/Main.tscn` + `scripts/Main.cs` の最小構成
- `icon.svg` を追加
- `dotnet build` / `godot --headless --import` / `godot --headless --quit-after 5` の 3 ステップで動作確認

## 次にやること
- [ ] テストプロジェクト (`tests/`) 追加と `dotnet test` 動作確認
- [ ] 実機能の最初のシーン設計

## 既知の問題
- なし
