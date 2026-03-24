const copyButtons = document.querySelectorAll(".copy-snippet");
const year = document.querySelector("#year");

if (year) {
  year.textContent = new Date().getFullYear();
}

copyButtons.forEach((button) => {
  button.addEventListener("click", async () => {
    const code = button.closest(".code-snippet")?.querySelector("code");

    if (!code) {
      return;
    }

    try {
      await navigator.clipboard.writeText(code.textContent.trim());
      button.textContent = "Copied";
      window.setTimeout(() => {
        button.textContent = "Copy";
      }, 1600);
    } catch (error) {
      button.textContent = "Select text";
      window.setTimeout(() => {
        button.textContent = "Copy";
      }, 1600);
    }
  });
});
