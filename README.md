# Joseph Tabor's Game Development Portfolio

This portfolio is published with GitHub Pages and uses Jekyll to keep project
content separate from the homepage layout.

## Editing a project

Each project is a Markdown file in `_projects`. Edit the file's front matter
(the section between the `---` lines) to change its title, status, lead,
skills, images, code sample, or video. Edit the Markdown below the front matter
to change the long description.

The `lead` is the short description shown on the homepage tile and at the top
of the project's page. When a project has a `logo`, it is used on the homepage
tile and beside the project title. Otherwise, the first `images` entry is used
on the homepage tile. Every `images` entry appears in the project gallery.

An optional `logo` is displayed beside the project title and stays separate
from the gallery:

```yaml
logo:
  src: assets/project-logo.png
  alt: Project logo
```

When a project does not define a logo, its first gallery image is also used
beside the title.

Projects are displayed according to their numeric `order` value. Each Markdown
filename also becomes its page address, so `_projects/windowed.md` is published
at `/projects/windowed/`.

## Editing a code sample

Code samples are stored as normal C# files in `_includes/snippets`. A project's
`code.file` field selects the sample displayed on its project page:

```yaml
code:
  label: C# grid-based movement snippet
  caption: The main function used to move the character and push blocks
  file: snippets/windowed-try-step.cs
  language: csharp
```

Remove the entire `code` section from a project if it should not display a code
sample.

## Adding a video

Project pages support both local MP4 files and hosted video embeds. For an MP4,
place the file in `assets` and add a `video.file` entry:

```yaml
video:
  label: Project Trailer
  caption: Trailer for the project.
  title: Project trailer
  file: assets/trailer.mp4
  type: video/mp4
  poster: assets/project-cover.png
```

For a YouTube or similar embed, use `video.url` instead of `video.file`. The
shared project layout selects the appropriate player automatically.

## Adding a project

1. Copy an existing Markdown file in `_projects`.
2. Give it a unique filename and update its front matter and description.
3. Add any screenshots to `assets` and code samples to `_includes/snippets`.
4. Set its `order` value to control where it appears on the homepage.

Homepage tiles are rendered by `_includes/project-tile.html`. Dedicated project
pages use `_layouts/project.html`. Neither file normally needs to be changed
when adding or editing project content.
