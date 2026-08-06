---
title: Windowed
order: 1
technology: Unity / C#
status: Intro to Game Dev Final Project
lead: >-
  A puzzle game based on the icons in the corner of a program window. 2D
  environment with a character that has the ability to push, close, resize, and
  minimize blocks to solve the puzzles.
skills:
  - Movement Systems
  - Interaction Design
logo:
  src: assets/windowedlogo.png
  alt: Windowed logo
images:
  - src: assets/windowedss.png
    alt: In-game screen shot of a puzzle
    aria_label: Open Windowed screenshot
    caption: In-game screen shot of one of the puzzles.
    featured: true
  - src: assets/windowedclicking.png
    alt: The player using the cursor to interact with a block in Windowed
    aria_label: Open Windowed cursor interaction screenshot
    caption: Using direct cursor input to interact with a puzzle block.
  - src: assets/windowedlevel1.png
    alt: Full level 1
    aria_label: Open Windowed level layout
    caption: Full level 1 layout.
code:
  label: C# grid-based movement snippet
  caption: The main function used to move the character and push blocks
  file: snippets/windowed-try-step.cs
  language: csharp
video:
  label: Gameplay Video
  caption: Demo of the first few levels.
  title: Windowed gameplay video
  url: https://www.youtube-nocookie.com/embed/i4oEKTNzUsE
---
I worked on designing and implementing the core puzzle systems, focusing on how players interact with the environment through both character movement and direct cursor input. The main challenge was creating intuitive mechanics based on familiar UI symbols (minimize, close, resize) while ensuring they translated into meaningful and solvable puzzle interactions. To address this, I helped develop a grid-based system that simplified movement and interactions, reducing edge cases and allowing for more controlled puzzle design. I also contributed to implementing core mechanics such as clickable blocks, state-changing buttons, and environmental constraints like glass barriers, all of which were introduced progressively to guide player understanding. One key design consideration was preventing soft-lock scenarios, which led to the addition of a reset mechanic and a more intentional level design. This project was interesting to work on, as it had the challenge of conveying what UI elements would do in a gameplay scenario while still making them feel satisfying and fun to interact with.
