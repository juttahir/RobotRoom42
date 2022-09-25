// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example
var ctx = document.getElementById("myPieChart");
var myPieChart = new Chart(ctx, {
  type: 'doughnut',
  data: {
    labels: ["Direct", "Referral", "Social"],
    datasets: [{
      data: [85, 10, 5],
    }],
  },
  options: {
    maintainAspectRatio: false,
    tooltips: {
      backgroundColor: "rgb(255,255,255)",
      bodyFontColor: "#858796",
      borderColor: '#dddfeb',
      borderWidth: 1,
      xPadding: 15,
      yPadding: 15,
      displayColors: false,
      caretPadding: 10,
    },
    legend: {
      display: false
    },
    cutoutPercentage: 80,
  },
});

(function () {

    function createCanvas() {
        var canvas = document.createElement('canvas');
        canvas.style.position = 'fixed';
        canvas.style.left = '-5000px';
        canvas.style.maxWidth = '3000px';
        document.body.appendChild(canvas);

        return canvas;
    }

    window.pwgiImagemRotateImg = function (img, deg) {
        var canvas,
            context;

        if (!img.dataset.original) {
            img.dataset.original = img.src;
        }

        var cloneImg = new Image();
        cloneImg.crossOrigin = 'anonymous';
        cloneImg.addEventListener('load', function () {
            canvas = createCanvas();
            context = canvas.getContext('2d');
            canvas.width = this.height;
            canvas.height = this.width;
            context.clearRect(0, 0, this.width, this.height);
            context.save();
            context.translate(canvas.width / 2, canvas.height / 2);
            context.rotate(deg * Math.PI / 180);
            context.drawImage(this, -this.width / 2, -this.height / 2);
            context.restore();
            img.src = canvas.toDataURL('image/jpeg');
            img.dataset.rotated = deg;
            canvas.parentElement.removeChild(canvas);
            cloneImg = null;
        });
        cloneImg.src = img.dataset.original;
    };

}());