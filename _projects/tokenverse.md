---
title: Tokenverse Chapter 1
order: 2
technology: Unity / C#
status: Undergrad Research (WIP)
lead: >-
  A game about AI systems and their effects on users. The player assumes the
  role of a AI agent, answering request through the metaphor of a virtual bar.
skills:
  - Interaction Design
  - Gameplay Systems
logo:
  src: assets/tokenverse.png
  alt: Tokenverse logo
images:
  - src: assets/tokenverseimage.png
    alt: Screenshot of the Normal mode area
    aria_label: Tokenverse
    caption: Setting of the game
    featured: true
code:
  label: Context-Aware Object Placement
  caption: Objects follow the mouse along a camera-aligned drag plane, then snap to valid placement points. Customer interaction points receive a larger effective selection radius, making off-plane actions feel natural without requiring precise 3D cursor positioning.
  file: snippets/tokenverse-resolve-case.cs
  language: csharp
video:
  label: Project Trailer
  caption: Trailer for Tokenverse Chapter 1.
  title: Tokenverse Chapter 1 trailer
  file: assets/Tokenverse trailer.mp4
  type: video/mp4
  poster: assets/tokenverseimage.png
---
This project is still a work in progress, but my role on the team is as one of two programmers, along with seven designers, artist, and leads. From the beginning, the project had a clear identity, but many of the smaller gameplay details still needed to be worked out. During the first few weeks, I worked closely with our gameplay designers to finalize the interactions that I would eventually implement.

The section of the game I was responsible for takes place in a bar, where the player reads requests from an AI model's user and decides whether to approve or deny them by providing, or withholding, food and drinks. Similar to *Papers, Please*, this required an evaluation system as well as a way for the player to move and interact with objects around a workstation.

Because the game is set in 3D, creating a satisfying object movement system presented a particular challenge. I initially created a free-dragging system, but I ran into issues translating two-dimensional mouse movement into the angled three-dimensional space. The player needed to move objects across the desk, hand items to customers, and interact with equipment outside the desk's boundaries.

To address this, I implemented a more restrictive system in which players selected objects and placed them into predefined locations. This worked well internally and solved the problems caused by unrestricted movement. However, after playtesting with new players, it became clear that I had overcomplicated the interaction and required too many clicks for relatively simple actions.

Using this feedback, I returned to my original dragging system with additional guardrails. By adding predefined placement points, I was able to restrict objects to valid locations while preserving the satisfying feeling of dragging and snapping them into place. To account for interaction points that were not on the same plane as the desk, such as the customer's hand, I adjusted how the snapping distance was calculated. This allowed objects to snap naturally to elevated or distant locations even when they were not physically close in three-dimensional space.

In addition to the main gameplay loop, I was responsible for implementing free-roam movement outside the workstation and creating the game's dialogue system. The dialogue system began as a simple feature but quickly developed into a modular framework capable of handling camera transitions, user interface elements, player input restrictions, and character interactions. By separating these features into reusable modules, I made it possible to create and modify complex dialogue sequences without rewriting the underlying system.

As my first experience working on a team of nine people, this project has taught me a great deal about teamwork and communication across different disciplines. I regularly communicated with designers, artists, writers, researchers, and the other programmer to ensure that the systems I developed supported both the creative direction and the educational goals of the project. I also learned how important it is to explain technical limitations clearly, ask for feedback early, and remain flexible when an initial solution does not work well for the rest of the team or the player. Working in a larger group has helped me become more comfortable sharing progress, documenting my systems, responding to critique, and adapting my work to fit into a broader production pipeline.
