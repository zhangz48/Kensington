function scrollToSection(sectionId) {
    let target;

    if (sectionId === 'home') {
        // Scroll to the top of the page
        target = document.body;
    } else {
        // Scroll to the specific section
        target = document.getElementById(sectionId);
    }

    if (target) {
        target.scrollIntoView({ behavior: 'smooth' });
    }
}