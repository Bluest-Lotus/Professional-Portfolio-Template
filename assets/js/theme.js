const toggle = document.getElementById("theme-toggle");
const icon = document.getElementById("theme-icon");

function setTheme(theme) {
  document.documentElement.setAttribute("data-theme", theme);
  localStorage.setItem("theme", theme);
  icon.textContent = theme === "dark" ? "🌙" : "🌞";
}

toggle.addEventListener("click", () => {
  const current = localStorage.getItem("theme") || "light";
  setTheme(current === "light" ? "dark" : "light");
});

setTheme(localStorage.getItem("theme") || "light");