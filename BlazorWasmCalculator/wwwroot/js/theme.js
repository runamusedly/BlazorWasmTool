window.setTheme = function (theme) {
    const body = document.getElementById("app-body");

    body.classList.remove("theme-samsung-light", "theme-samsung-dark", "theme-samsung-dark-bluetech", "theme-skhynix-light", "theme-skhynix-dark");
    body.classList.add(theme);
};

window.themeStorage = {
    saveTheme: function (theme) {
        localStorage.setItem("theme", theme);
    },
    loadTheme: function () {
        return localStorage.getItem("theme");
    }
};