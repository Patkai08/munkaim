function szamitas() {
    a = document.getElementById("a").value;
    b = document.getElementById("b").value;
    c = document.getElementById("c").value;

    m = b * b - 4 * a * c
    if(m < 0) {
        document.getElementById("eredmeny").innerHTML = "nincs eredmeny";
    } else if (m == 0) {
        x = -b / (2 * a);
        document.getElementById("eredmeny").innerHTML = x;
    } else {
        x1 = (-b + Math.sqrt(m)) / (2 * a)
        x2 = (-b - Math.sqrt(m)) / (2 * a)
        document.getElementById("eredmeny").innerHTML = x1 + " és " + x2;
    }
}