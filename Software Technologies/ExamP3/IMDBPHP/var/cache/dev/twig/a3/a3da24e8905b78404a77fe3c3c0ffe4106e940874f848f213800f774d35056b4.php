<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_a4cd7a2006cdc8e18242281de8a2d29f108798c836d5a362698d0ec8a3d4a9a6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a4cd7a2006cdc8e18242281de8a2d29f108798c836d5a362698d0ec8a3d4a9a6->enter($__internal_a4cd7a2006cdc8e18242281de8a2d29f108798c836d5a362698d0ec8a3d4a9a6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_b4900585995d85d89b6dadd00a714bba66f761bb75266b23bc24672a3e57caa1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b4900585995d85d89b6dadd00a714bba66f761bb75266b23bc24672a3e57caa1->enter($__internal_b4900585995d85d89b6dadd00a714bba66f761bb75266b23bc24672a3e57caa1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 17
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 20
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 21
        $this->displayBlock('body', $context, $blocks);
        // line 24
        echo "</body>
</html>
";
        
        $__internal_a4cd7a2006cdc8e18242281de8a2d29f108798c836d5a362698d0ec8a3d4a9a6->leave($__internal_a4cd7a2006cdc8e18242281de8a2d29f108798c836d5a362698d0ec8a3d4a9a6_prof);

        
        $__internal_b4900585995d85d89b6dadd00a714bba66f761bb75266b23bc24672a3e57caa1->leave($__internal_b4900585995d85d89b6dadd00a714bba66f761bb75266b23bc24672a3e57caa1_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_fc1b5ad640c29f12c6741c7029bb27cf56e38edaec09d7c7e0c8f18b0454a95f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fc1b5ad640c29f12c6741c7029bb27cf56e38edaec09d7c7e0c8f18b0454a95f->enter($__internal_fc1b5ad640c29f12c6741c7029bb27cf56e38edaec09d7c7e0c8f18b0454a95f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_75c1473eeaca11b758630fa23e241f733d643da8b66c8f2aff5a98a24552663e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_75c1473eeaca11b758630fa23e241f733d643da8b66c8f2aff5a98a24552663e->enter($__internal_75c1473eeaca11b758630fa23e241f733d643da8b66c8f2aff5a98a24552663e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "IMDB";
        
        $__internal_75c1473eeaca11b758630fa23e241f733d643da8b66c8f2aff5a98a24552663e->leave($__internal_75c1473eeaca11b758630fa23e241f733d643da8b66c8f2aff5a98a24552663e_prof);

        
        $__internal_fc1b5ad640c29f12c6741c7029bb27cf56e38edaec09d7c7e0c8f18b0454a95f->leave($__internal_fc1b5ad640c29f12c6741c7029bb27cf56e38edaec09d7c7e0c8f18b0454a95f_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_ef37f2b8544a2e5fad0eb84ac4c075c045cb196ffe5ddb51cf46b5930c72804b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ef37f2b8544a2e5fad0eb84ac4c075c045cb196ffe5ddb51cf46b5930c72804b->enter($__internal_ef37f2b8544a2e5fad0eb84ac4c075c045cb196ffe5ddb51cf46b5930c72804b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_e707ca9d348cdfa5903b376a68d35247e5cafd9e3252fc0aa9184b343ad9fa89 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e707ca9d348cdfa5903b376a68d35247e5cafd9e3252fc0aa9184b343ad9fa89->enter($__internal_e707ca9d348cdfa5903b376a68d35247e5cafd9e3252fc0aa9184b343ad9fa89_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        ";
        // line 14
        echo "        ";
        // line 15
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_e707ca9d348cdfa5903b376a68d35247e5cafd9e3252fc0aa9184b343ad9fa89->leave($__internal_e707ca9d348cdfa5903b376a68d35247e5cafd9e3252fc0aa9184b343ad9fa89_prof);

        
        $__internal_ef37f2b8544a2e5fad0eb84ac4c075c045cb196ffe5ddb51cf46b5930c72804b->leave($__internal_ef37f2b8544a2e5fad0eb84ac4c075c045cb196ffe5ddb51cf46b5930c72804b_prof);

    }

    // line 20
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_282fd4e03482b367a38893beb7ccbc0121a224818da259038ce5c6d6d3aeebcc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_282fd4e03482b367a38893beb7ccbc0121a224818da259038ce5c6d6d3aeebcc->enter($__internal_282fd4e03482b367a38893beb7ccbc0121a224818da259038ce5c6d6d3aeebcc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_2bc4dfe78bd15f1ec424cb01ab2a12f81d6c09c69831e1ffa49fb317494ef792 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2bc4dfe78bd15f1ec424cb01ab2a12f81d6c09c69831e1ffa49fb317494ef792->enter($__internal_2bc4dfe78bd15f1ec424cb01ab2a12f81d6c09c69831e1ffa49fb317494ef792_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_2bc4dfe78bd15f1ec424cb01ab2a12f81d6c09c69831e1ffa49fb317494ef792->leave($__internal_2bc4dfe78bd15f1ec424cb01ab2a12f81d6c09c69831e1ffa49fb317494ef792_prof);

        
        $__internal_282fd4e03482b367a38893beb7ccbc0121a224818da259038ce5c6d6d3aeebcc->leave($__internal_282fd4e03482b367a38893beb7ccbc0121a224818da259038ce5c6d6d3aeebcc_prof);

    }

    // line 21
    public function block_body($context, array $blocks = array())
    {
        $__internal_c90633338728f30c98824b35fff3d1cf767b12017c5eff48e8fe99cbde07852c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c90633338728f30c98824b35fff3d1cf767b12017c5eff48e8fe99cbde07852c->enter($__internal_c90633338728f30c98824b35fff3d1cf767b12017c5eff48e8fe99cbde07852c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_2c40f3c468dd1a73bf1c4d6e1859e6f24ded8e6287fa8306360b4ff1240f6a7d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2c40f3c468dd1a73bf1c4d6e1859e6f24ded8e6287fa8306360b4ff1240f6a7d->enter($__internal_2c40f3c468dd1a73bf1c4d6e1859e6f24ded8e6287fa8306360b4ff1240f6a7d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 22
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_2c40f3c468dd1a73bf1c4d6e1859e6f24ded8e6287fa8306360b4ff1240f6a7d->leave($__internal_2c40f3c468dd1a73bf1c4d6e1859e6f24ded8e6287fa8306360b4ff1240f6a7d_prof);

        
        $__internal_c90633338728f30c98824b35fff3d1cf767b12017c5eff48e8fe99cbde07852c->leave($__internal_c90633338728f30c98824b35fff3d1cf767b12017c5eff48e8fe99cbde07852c_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_e3e69220282d2cde40f8957f4ebdc3bf3ecd22ff8142326b1225ff9e45eade8b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e3e69220282d2cde40f8957f4ebdc3bf3ecd22ff8142326b1225ff9e45eade8b->enter($__internal_e3e69220282d2cde40f8957f4ebdc3bf3ecd22ff8142326b1225ff9e45eade8b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_8b5d7ea7805df5f205ce4acc9042e8b11c5c1d54e6dad425e6e2757b1e402c5b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8b5d7ea7805df5f205ce4acc9042e8b11c5c1d54e6dad425e6e2757b1e402c5b->enter($__internal_8b5d7ea7805df5f205ce4acc9042e8b11c5c1d54e6dad425e6e2757b1e402c5b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_8b5d7ea7805df5f205ce4acc9042e8b11c5c1d54e6dad425e6e2757b1e402c5b->leave($__internal_8b5d7ea7805df5f205ce4acc9042e8b11c5c1d54e6dad425e6e2757b1e402c5b_prof);

        
        $__internal_e3e69220282d2cde40f8957f4ebdc3bf3ecd22ff8142326b1225ff9e45eade8b->leave($__internal_e3e69220282d2cde40f8957f4ebdc3bf3ecd22ff8142326b1225ff9e45eade8b_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 22,  129 => 21,  112 => 20,  99 => 15,  97 => 14,  95 => 13,  86 => 12,  68 => 11,  56 => 24,  54 => 21,  50 => 20,  43 => 17,  41 => 12,  37 => 11,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}IMDB{% endblock %}</title>
    {% block stylesheets %}
        {#<link rel=\"stylesheet\" href=\"{{ asset('css/reset-style.css') }}\">;#}
        {#<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">#}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\app\\Resources\\views\\base.html.twig");
    }
}
