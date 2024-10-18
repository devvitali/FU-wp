<?php
$text = get_field('title_con');
$descr = get_field('description_con');
?>

    <div class="contacts">
        <div class="container">
            <div class="contacts-wrapper">
                <div class="contacts-info">
                    <h3><?php echo $text; ?></h3>
                    <?php echo $descr; ?>
                </div>
                <div class="contacts-map">
					<iframe src="https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d9375.541004024128!2d-88.67030283246754!3d17.279632960227143!3m2!1i1024!2i768!4f13.1!5e1!3m2!1sen!2sua!4v1727780460480!5m2!1sen!2sua" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                </div>
            </div>
        </div>
    </div>