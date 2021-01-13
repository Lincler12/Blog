
const Create = (() => {
    const tabButtons = document.querySelectorAll("[data-toggle='tab'");
    const tabPanes = document.querySelectorAll(".tab-pane");
   
    const displayContent = (e) => {
        const idNameArray = e.target.id.split("-");
        tabPanes.forEach(tabPane => {
            if (!(tabPane.id === idNameArray[0])) {
                tabPane.classList.add("display-none");
            } else {
                tabPane.classList.remove("display-none");
            }
        })
    }
    tabButtons.forEach(tabButton => {
        tabButton.addEventListener("click", displayContent);
    })
})();
